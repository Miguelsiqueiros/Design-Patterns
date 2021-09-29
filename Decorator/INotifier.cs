using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface INotifier
    {
        void send(string msg);
    }
}
