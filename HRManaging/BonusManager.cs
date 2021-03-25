using HRManaging.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManaging
{
    class BonusManager
    {
        private static double _totalBonus;
        private static int _totalEmployees;
        public void RegisterBonus(Employee employee)
        {
            _totalBonus += employee.GetBonus();
            _totalEmployees++;
        }
        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}
