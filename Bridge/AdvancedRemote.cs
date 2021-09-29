using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class AdvancedRemote : Remote
    {

        public AdvancedRemote(Device device) : base(device)
        {

        }

        public void mute()
        {
            this.device.Volume = 0;
        }
    }
}
