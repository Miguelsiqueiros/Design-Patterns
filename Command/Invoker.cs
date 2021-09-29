using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoker
    {
        private ICommand OnStart;
        private ICommand OnFinish;

        public void SetOnStart(ICommand OnStart)
        {
            this.OnStart = OnStart;
        }

        public void SetOnFinish(ICommand OnFinish)
        {
            this.OnFinish = OnFinish;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: do important stuff");
            if(this.OnStart != null)
            {
                Console.WriteLine("Invoker: run onStart");
                this.OnStart.Excecute();
            }

            if(this.OnFinish != null)
            {
                Console.WriteLine("Invoker: run onFinish");
                this.OnFinish.Excecute();
            }
        }
    }
}
