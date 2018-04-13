using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Problem_9_3_Personal_Information_Class
{
    class PersonalInfo
    {
        private string _name;       // The person's name
        private string _address;    // The person's address
        private int _age;           // The person's age
        private string _phone;      // The person's telephone

        public PersonalInfo()
        {
            _name = "";
            _address = "";
            _age = 0;
            _phone = "";
        }

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

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

    }
}
