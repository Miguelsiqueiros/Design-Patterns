using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: working on {a}");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: working on {b}");
        }
    }
}
