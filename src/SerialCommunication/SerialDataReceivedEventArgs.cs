﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whitestone.OpenSerialPortMonitor.SerialCommunication
{
    public class SerialDataReceivedEventArgs : EventArgs
    {
        public byte[] Data { get; set; }
    }
}
