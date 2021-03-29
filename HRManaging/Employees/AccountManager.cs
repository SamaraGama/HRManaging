﻿using HRManaging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Employees
{
    class AccountManager : Employee, IAuthenticable
    {
        public string Password { get; set; }
        public AccountManager(string name, string id, double salary) : base(name, id, salary)
        {
        }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
        public override double GetBonus()
        {
            return Salary * 0.25;
        }
        public override void GetRaise()
        {
            Salary *= 1.5;
        }
    }
}
