using System;
using System.IO.Ports;

namespace Lut.Communication
{
    public class SerialInfo
    {
        public string PortName { get; set; } = "COM3";
        public int BaudRate { get; set; } = 115200;
        public int DataBit { get; set; } = 8;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;
    }
}
