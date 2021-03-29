using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging.Interfaces
{
    public interface IAuthenticable 
    {
        bool Authenticate(string password);
    }
}
