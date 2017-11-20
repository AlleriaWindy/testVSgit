using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO.Ports;
using System.Threading;

namespace SensorPic2.Hardware
{
    class MySerialPort : IDataSR
    {
        public event MyDataRecivedDelegate DataRecived;
        private string PortName { get; set; }
        private int BuadRate { get; set; }
        protected SerialPort Port { get; set; }
        public int PoolSleepTime { get; set; }

        private Thread RecivePoolTh;
        private bool _thrun = false;
        private bool _isrunning = false;
        

        private void RunNewTh(byte[] data)
        {
            Thread th = new Thread(new ParameterizedThreadStart(
                (obj) =>
                {
                    DataRecived(this, (byte[])obj);
                }
                ));
            th.Start(data);
        }

        private void RecPoolFunc()
        {
            bool isrec = false;
            int notime = 0;
            List<byte> buff = new List<byte>();
            int last_sum = 0;
            while (_thrun)
            {
                _isrunning = true;
                int sum = Port.BytesToRead;
                if (sum > 0)
                {
                    if (last_sum == 0)
                        buff.Clear();
                    for (int i = 0; i < sum; i++)
                    {
                        byte b = (byte)Port.ReadByte();
                        buff.Add(b);
                    }
                }
                else
                {
                    if (last_sum > 0)
                        RunNewTh(buff.ToArray());
                        //DataRecived(this, buff.ToArray());
                }
                last_sum = sum;
                sum = 0;
                Thread.Sleep(PoolSleepTime);
            }
            _isrunning = false;
        }

        public MySerialPort(string name, int buadrate)
        {
            this.PortName = name;
            this.BuadRate = buadrate;
            PoolSleepTime = 10;
            Port = new SerialPort(PortName, BuadRate);
            
            
        }

        public MySerialPort()
        {
            PoolSleepTime = 10;
           
            
        }

        public void Init(object[] param)
        {
            if (Port != null)
                return;
            if (param.Length >= 2)
            {
                PortName = (string)param[0];
                BuadRate = (int)param[1];
            }
            Port = new SerialPort(PortName, BuadRate);
        }

        public void Open()
        {
            if (!Port.IsOpen)
            {
                Port.Open();
                if (!_isrunning)
                {
                    RecivePoolTh = new Thread(new ThreadStart(RecPoolFunc));
                    _thrun = true;
                    RecivePoolTh.Start();
                }
                if (RecivePoolTh.ThreadState == ThreadState.Suspended)
                    RecivePoolTh.Resume();
            }
        }

        public void Close()
        {
            if (Port.IsOpen)
            {
                if (RecivePoolTh.ThreadState == ThreadState.Running)
                    RecivePoolTh.Suspend();
                Port.Close();
            }
        }

        public int SendData(byte[] data)
        {
            Port.Write(data,0,data.Length);
            return data.Length;
        }

        public void Release()
        {
            if (Port != null)
            {
                
                _thrun = false;
                while (_isrunning) ;
                Port.Close();
                Port.Dispose();
                RecivePoolTh = null;
                Port = null;
            }
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                this.Release();
                
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        ~MySerialPort()
        {
            this.Dispose(false);
        }
    }
}
