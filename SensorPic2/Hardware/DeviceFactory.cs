using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorPic2.Hardware
{
    public enum JDevicesEnum
    {
        Unkown = 0x00,
        SerialPort = 0x01
    }
    static class DeviceFactory
    {
        public static IDataSR GetDevice(JDevicesEnum dv)
        {
            switch (dv)
            {
                case JDevicesEnum.SerialPort: return new MySerialPort(); break;
                default: throw new Exception("未知设备！");
            }
        }
    }
}
