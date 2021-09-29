using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Remote
    {
        public Device device;

        public Remote(Device device)
        {
            this.device = device;
        }

        public void tooglePower()
        {
            this.device.IsEnabled = !this.device.IsEnabled;
        }

        public void volumeDown()
        {
            if(this.device.Volume > 0)
            {
                this.device.Volume--;
            }
        }

        public void volumeUp()
        {
            if(this.device.Volume < 100)
            {
                this.device.Volume++;
            }
        }

        public void channelUp()
        {
            if (this.device.Channel < 100)
            {
                this.device.Channel++;
            }
        }

        public void channelDown()
        {
            if (this.device.Channel > 0)
            {
                this.device.Channel--;
            }
        }
    }
}
