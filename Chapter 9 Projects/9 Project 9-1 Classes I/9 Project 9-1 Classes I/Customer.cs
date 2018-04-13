using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_1_Classes_I
{
    // Creating Customer class
    class Customer
    {
        string firstName;
        string lastName;
        int custID;


        // DisplayCustomerInfo method set class field to certain values
        public void displayCustomerInfo()
        {
            // Initializing Customer class fields
            // If you commented out the fields below, the default constructor 
            //     will set these fields to dafault values
            firstName = "Jill";
            lastName = "Smith";
            custID = 555;

            // Display fields on the message box
            MessageBox.Show("Customer First Name: " + firstName +
                  "\nCustomer Last Name: " + lastName +
                  "\nCustomer ID: " + custID);

        }

    }
}
