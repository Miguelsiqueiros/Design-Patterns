using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("I'm simple command"));
            
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Send report"));

            invoker.DoSomethingImportant();
        }
    }
}
