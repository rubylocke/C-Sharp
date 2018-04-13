using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem_10_4_Person_and_Customer
{
    class Person
    {
        // Variables
        public string _name;
        public string _address;
        public string _phone;

        public Person()
        {

        }

        // getters and setters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
