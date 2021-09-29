using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private readonly string payload;

        public SimpleCommand(string payload)
        {
            this.payload = payload;
        }

        public void Excecute()
        {
            Console.WriteLine($"Simple command: {this.payload}");
        }

    }
}
