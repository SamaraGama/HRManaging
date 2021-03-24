using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    class Designer : Employee
    {
        public Designer(string name, string id, double salary) : base(name, id, salary)
        {     
        }
        public override double GetBonus()
        {
            return Salary * 0.17; 
        }
        public override void GetRaise()
        {
            Salary += 0.11;
        }
    }
}
