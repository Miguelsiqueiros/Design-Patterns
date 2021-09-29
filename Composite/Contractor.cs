using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Contractor : IEmployee
    {
        public int EmployeeId { get ; set; }
        public string Name { get; set ; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Id: {EmployeeId}");
        }
    }
}
