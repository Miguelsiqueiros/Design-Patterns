using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant miguel = new Participant("miguel");
            Participant bob = new Participant("bob");
            Participant mary = new Participant("mary");

            Chatroom chatroom = new Chatroom();
            chatroom.Register(miguel);
            chatroom.Register(bob);
            chatroom.Register(mary);

            miguel.Send("bob", "Hi Bob");
            bob.Send("mary", "Hi Mary");
            mary.Send("miguel", "Hi Miguel");
        }
    }
}
