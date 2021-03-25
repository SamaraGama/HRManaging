using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }
        public virtual double Salary { get; protected set; }
        public Employee(string name, string id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
            TotalEmployees++;
        }
        public virtual double GetBonus()
        {
            return Salary * 0.10;
        }
        public virtual void GetRaise()
        {
            //Salay = Salary + (Salary + 0.1);
            //Salary = Salary * 1.1;
            Salary *= 1.1;
        }
    }
}
