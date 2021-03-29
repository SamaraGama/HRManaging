using HRManaging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    public class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }
        public AuthenticableEmployee(string name, string id, double salary) : base(name, id, salary)
        {
        }
        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
