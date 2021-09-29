using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IParticipant
    {
        void Send(string to, string message);
        void Receive(string from, string message);
    }
}
