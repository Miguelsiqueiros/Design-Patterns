using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class FacebookDecorator: NotifierDecorator
    {
        private INotifier notifier;

        public FacebookDecorator(INotifier notifier): base()
        {
            this.notifier = notifier;
        }

        public override void send(string msg)
        {
            notifier.send(msg);
            Extra(msg);
        }

        private void Extra(string msg)
        {
            Console.WriteLine($"{msg} send from Facebook");
        }
    }
}
