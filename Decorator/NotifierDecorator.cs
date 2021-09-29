using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class NotifierDecorator: INotifier
    {
        private INotifier notifier;

        public NotifierDecorator()
        {

        }

        public NotifierDecorator(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public abstract void send(string msg);
    }
}
