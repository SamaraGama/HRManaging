using HRManaging.Employees;
using HRManaging.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            Designer employee1 = new Designer("Jane Doe", "0001", 3000);
            employee1.GetBonus();
            Console.WriteLine($"{employee1.Name} is a {employee1.GetType()}. Id: {employee1.Id}. Salary: {employee1.Salary}. ");
            Console.WriteLine(Employee.TotalEmployees);
            employee1.GetRaise();
            Console.WriteLine($"{employee1.Name}'s salary after a raise is {employee1.Salary}.");

            Director director1 = new Director("John Doe", "0002", 5000);
            director1.GetBonus();
            Console.WriteLine($"{director1.Name} is a {director1.GetType()}. Id: {director1.Id}. Salary: {director1.Salary}.");
            Console.WriteLine(Employee.TotalEmployees);
            director1.GetRaise();
            Console.WriteLine($"{director1.Name}'s salary after a raise is {director1.Salary}.");
            
            UseInSystem();
            Console.ReadLine();
        }
        public static void UseInSystem()
        {
            InSystem inSystem = new InSystem();
            Director director2 = new Director("Joseph Deo", "0004", 10000);
            director2.Password = "Joseph'sPassword";
            inSystem.LogIn(director2, "Joseph'sPassword");
            inSystem.LogIn(director2, "NOTJoseph'sPassword");
        }
    }
}
