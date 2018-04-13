using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_3_Poly_and_Inherit
{
    // Base class Person
    class Person
    {
        //Class Private fields
        private string _firstName;
        private string _lastName;
        private string _occupation;

        // Default Constructor
        public Person()
        {
            _firstName = "";
            _lastName = "";
            _occupation = "";
        }

        // Parameterized constuctor
        public Person(string FirstName, string LastName, string Occupation)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _occupation = Occupation;
        }

        // Properties to allow access to class fields
        public string  FName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }

        // Display info Method
        public void displayInfo()
        {
            MessageBox.Show("First name: " + _firstName +
                "\nLast Name: " + _lastName +
                "\nOccupation: " + _occupation, "Base class!");
        }

        // Virtual method in the base class is meant to be overriden by 
        // a method in the derived class HAVING the same name and Signature
        public virtual void setOccupation(string _OCC)
        {
            MessageBox.Show("No method override happened" + _OCC);
        }

    }
}
