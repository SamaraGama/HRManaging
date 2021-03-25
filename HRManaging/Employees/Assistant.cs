using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    class Assistant : Employee
    {
        public Assistant(string name, string id, double salary) : base(name, id, salary)
        {
        }
        public override double GetBonus()
        {
            return Salary * 0.2;
        }
        public override void GetRaise()
        {
            Salary *= 1.1;
        }
    }
}
