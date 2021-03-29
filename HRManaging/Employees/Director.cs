using HRManaging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string name, string id, double salary) : base(name, id, salary)
        {
        }
        public override double GetBonus()
        {
            //return Salary + base.GetBonus();
            return Salary * 0.5;
        }
        public override void GetRaise()
        {
            Salary *= 1.15;
        }
    }
}
