using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_1_Classes_I
{
    /*
    A class is a blueprint/template for objects. It has attributes which are represented by the class
        fields (class variables). It also has behavior (properties) represented by the class methods.
    A class is used to store data about objects.
    Class name usually starts with an uppercase letter.
    A class can have complex user-defined datatypes such as customer datatype to store 
      infomration about a customer.
    Access modifier is set t private by default if it is not specified
    Creating Emplyee class
    */
    class Employee
    {
        // class fields
        // if there is no access modified, it is then set to private
        string _firstName;
        string _lastName;
        int _id;
        int _age;

        /*
        Create a constructor to initialize class fields.
        Constructor does not return anything.
        Constructor must have the same name of the class.
        By default, C# creates a default constructor when an object is created.
        The default constructor has no parameters and is garbage collected once you
           create your own parameterized constructor.
        Default constructor is used to set class fields to default values.
        Shortcut to create a constructor, type ctor then press tab twice.
        The constructor below is a parameterized contructor
        */
        public Employee(string fn, string ln, int ID, int Age)
        {
            // this keyword is a reference to an object of the class
            // this keyword is NOT necessary but better to have in class
            // the variables and the class fields are identical
            this._firstName = fn;
            this._lastName = ln;
            this._id = ID;
            this._age = Age;
        }

        // Overloading the constructor
        public Employee(string fn, string ln, int ID)
        {
            _firstName = fn;
            _lastName = ln;
            _id = ID;
        }

        // Overloading the constructor
        public Employee(string fname)
        {
            _firstName = fname;
        }

        // Overloading the constructor
        public Employee()
        {
        }

        // Displaying Employee Info
        public void displayEmployeeInfo()
        {
            MessageBox.Show("Employee First Name: " + _firstName +
                "\nEmployee Last Name: " + _lastName +
                "\nEmployee ID: " + _id +
                "\nEmployee Age: " + _age);
        }

    }
}
