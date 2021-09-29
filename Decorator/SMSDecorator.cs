using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SMSDecorator: NotifierDecorator
    {
        private INotifier notifier;

        public SMSDecorator(INotifier notifier): base()
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
            Console.WriteLine($"{msg} send from SMS");
        }
    }
}
