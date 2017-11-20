using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SensorPic2.Hardware
{
    public delegate void WindDataRecDele(object sender,Int32 speed,double dgree,double st,double temp);
 
    public class WindSensor1
    {
        protected ModbusPort Port1;
        public object Tag { get; set; }

        public event WindDataRecDele WindStrReced;
        public byte Address { get; set; }

        public WindSensor1(string pname,int buadrate)
        {
            Port1 = new ModbusPort(JDevicesEnum.SerialPort, new object[] {pname,buadrate });
            Port1.ModbusDataRecieved += Port1_ModbusDataRecieved;
           
        }


        public void SendDataRquest()
        {
            Port1.SendGeneral(new byte[] { 0x00, 0x02 ,0x00 ,0x04 }, Address, 0x04);
        }

        public void StartDevice()
        {
            Port1.Open();
        }

        public void PauseDevice()
        {
            Port1.Close();
        }

        protected virtual void Port1_ModbusDataRecieved(object sender, byte[] data)
        {
            if(data[0] != Address)
                return;
            if ( data[1] == 0x04 && data[2]==0x08)
            {
                Int32 speed = (data[3] << 8) + data[4];
                double degree = ((data[5]<<8) + data[6])/100.0;
                double st = ((data[7]<<8) + data[8])/10.0;
                double temp = ((data[9]<<8 )+ data[10])/10.0;
                WindStrReced(this,speed,degree,st,temp );
            }
        }

        public void StopDevice()
        {
            Port1.Dispose();
        }

        public void ChangeAddres(byte newaddr)
        {
            var dt = new byte[]{0x00,0x02 ,0x00 ,0x02 ,0x04 ,0x00 ,0x01 ,0x00 ,newaddr};
            Port1.SendGeneral(dt, Address, 0x10);
        }

        public void ChangeBuadRate(int bd)
        {
            byte hi = (byte)(bd / 256);
            byte low = (byte)(bd % 256);
            var dt = new byte[] { 0x00, 0x02, 0x00, 0x02, 0x04, 0x00, 0x02, hi, low };
            Port1.SendGeneral(dt, Address, 0x10);
        }

        public void ChangeSampleRate(byte tm)
        {
            var dt = new byte[] { 0x00, 0x02, 0x00, 0x02, 0x04, 0x00, 0x03, 0x00, tm };
            Port1.SendGeneral(dt, Address, 0x10);
        }
    }
}
