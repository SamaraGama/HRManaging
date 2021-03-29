using HRManaging.Employees;
using HRManaging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.System
{
    class InSystem
    {
        public bool LogIn(IAuthenticable employee, string password)
        {
            bool authenticated = employee.Authenticate(password);
            if (authenticated)
            {
                Console.WriteLine("Logged in successfully.");
                return true;
            }
            Console.WriteLine("Incorrect password.");
            return false;
        }
    }
}
