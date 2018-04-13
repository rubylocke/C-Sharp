using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem_10_1_Classes
{
    class ProductionWorker : Employee
    {
        public int _shift;
        public decimal _payRate;

        public ProductionWorker()
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

    }
}
