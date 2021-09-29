using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IChatroom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}
