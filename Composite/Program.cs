using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee miguel = new Employee()
            {
                EmployeeId = 5,
                Name = "Miguel"
            };

            IEmployee edmundo = new Employee()
            {
                EmployeeId = 6,
                Name = "Edmundo"
            };

            Employee supervisor = new Employee()
            {
                EmployeeId = 10,
                Name = "Hector"
            };

            Contractor developer = new Contractor()
            {
                EmployeeId = 5,
                Name = "Ernesto"
            };

            supervisor.AddSubordinate(miguel);
            supervisor.AddSubordinate(edmundo);

            supervisor.PrintSubordinates();

            supervisor.RemoveSubordinate(miguel);
            
            supervisor.AddSubordinate(developer);

            supervisor.PrintSubordinates();

            developer.PrintInfo();

        }
    }
}
