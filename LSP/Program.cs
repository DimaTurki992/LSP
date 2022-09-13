using System;
using EmployeeLib;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new CEO();

            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            // the following line cannot be be performed because an Employee cannot have a manager
            //emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            // or we can change the code into the following
            Managed emp2 = new Manager();
            emp2.FirstName = "Tom";
            emp2.LastName = "Lally";
            emp2.AssignManager(accountingVP);


            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
