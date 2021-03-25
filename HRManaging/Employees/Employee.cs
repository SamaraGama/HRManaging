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
        public abstract double GetBonus();
        public abstract void GetRaise();
    }
}
