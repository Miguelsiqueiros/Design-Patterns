using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface Device
    {
        bool IsEnabled { get; set; }
        void Enable();
        void Disable();
        int Volume { get; set; }
        int Channel { get; set; }
    }
}
