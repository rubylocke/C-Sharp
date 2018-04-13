using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Project_4_String_Returning_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // fullName method recieves three parameters:  firstName, middleName, and lastName
        // and returns a string
        private string fullName(string first, string middle, string last)
        {
            // Conatenating strings
            string Name = first + " " + middle + " " + last;
            return Name;
        }

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            // Declaration of name strings
            string firstName, middleName, lastName, YourFullName;

            // Get input from text boxes
            firstName = tbFirstName.Text;
            middleName = tbMiddleName.Text;
            lastName = tbLastName.Text;

            // Passing arguments to fullName method
            YourFullName = fullName(firstName, middleName, lastName);

            // Display the full name
            lblOutputFullName.Text = YourFullName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input variables
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            tbLastName.Text = "";

            // Clear the output
            lblOutputFullName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
