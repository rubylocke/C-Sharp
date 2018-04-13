using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem_10_2_ShiftSupervisor
{
    class Employee
    {
        public string _empName;
        public string _empNumber;

        public Employee()
        {

        }

        public string Name
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public string Number
        {
            get { return _empNumber; }
            set { _empNumber = value; }
        }

    }
}
