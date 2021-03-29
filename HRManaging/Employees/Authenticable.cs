using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    public abstract class Authenticable : Employee
    {
        public Authenticable(string name, string id, double salary) : base(name, id, salary)
        {
        }
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
