using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem_10_4_Person_and_Customer
{
    class Customer : Person
    {
        public int _custNo;
        public bool _mail;

        public Customer()
        {

        }

        // getters and setters
        public int CustNo
        {
            get { return _custNo; }
            set { _custNo = value; }
        }

        public Boolean Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
    }
}
