using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver receiver;
        private readonly string a;
        private readonly string b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this.receiver = receiver;
            this.a = a;
            this.b = b;
        }

        public void Excecute()
        {
            Console.WriteLine("ComplexCommand: doing complex stuff...");
            this.receiver.DoSomething(this.a);
            this.receiver.DoSomethingElse(this.b);
        }

    }
}
