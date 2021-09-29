using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Tv : Device
    {
        public bool IsEnabled { get; set; } = true;
        public int Volume { get; set; } = 5;
        public int Channel { get; set; } = 5;

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
