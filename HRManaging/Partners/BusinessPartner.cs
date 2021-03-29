using HRManaging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Partners
{
    class BusinessPartner : IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
