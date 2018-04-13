using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem_10_2_ShiftSupervisor
{
    class ShiftSupervisor : Employee
    {
        public int _shift;
        public decimal _payRate;
        public decimal _salary;
        public decimal _bonus;

        public ShiftSupervisor()
        {

        }

        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public decimal PayRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public decimal Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

    }
}
