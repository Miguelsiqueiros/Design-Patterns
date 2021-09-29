using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator()
            {
                State = "ON"
            };

            Caretaker caretaker = new Caretaker
            {
                Memento = originator.CreateMemento()
            };


            originator.State = "OFF";

            originator.SetMemento(caretaker.Memento);

            Console.Write(originator.State);
        }
    }
}
