using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Notifier : INotifier
    {
        public void send(string msg)
        {
            Console.WriteLine($"{msg} sent from notifier");
        }
    }
}
