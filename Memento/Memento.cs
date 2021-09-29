using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
