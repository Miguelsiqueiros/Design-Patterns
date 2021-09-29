using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Participant : IParticipant
    {
        public string Name { get; set; }
        public Chatroom chatroom { get; set; }

        public Participant(string name)
        {
            this.Name = name;
        }
        public void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: {message}");
        }

        public void Send(string to, string message)
        {
            chatroom.Send(Name, to, message);
        }
    }
}
