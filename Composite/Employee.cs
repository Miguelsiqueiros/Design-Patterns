using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Employee : IEmployee
    {
        private readonly List<IEmployee> subordinates = new List<IEmployee>();
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployee employee)
        {
            subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            subordinates.Remove(employee);
        }

        public void PrintSubordinates()
        {
            foreach(var employee in subordinates)
            {
                Console.WriteLine($"Employee: {employee.Name} Id: {employee.EmployeeId}");
            }
        }
    }
}
