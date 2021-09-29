using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Radio : Device
    {
        public bool IsEnabled { get; set; } = true;
        public int Volume { get; set; } = 10;
        public int Channel { get; set; } = 1;

        public void Disable()
        {
            this.IsEnabled = false;
        }

        public void Enable()
        {
            this.IsEnabled = true;
        }
    }
}
