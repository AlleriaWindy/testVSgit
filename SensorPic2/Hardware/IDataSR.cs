using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorPic2.Hardware
{
    public delegate void MyDataRecivedDelegate(object sender,byte[] data);
    public interface IDataSR:IDisposable
    {
        event MyDataRecivedDelegate DataRecived;
        int SendData(byte [] data);
        void Init(object [] param);
        void Release();
        void Open();
        void Close();
    }
}
