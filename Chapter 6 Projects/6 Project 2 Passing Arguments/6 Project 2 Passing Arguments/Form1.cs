using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Project_2_Passing_Arguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Age is a local variable and is set to receive argument
           from the calling method.  Since the default is to pass
           arguments by value it will just copy the value of age
           variable and pass it odnw to the Age variable */
        // byValue method accepts Age and returns nothing
        private void byValue(int Age)
        {
            Age = Age + 5;
        }

        // byRerence method accepts Age value by reference and returns nothing
        private void byReference(ref int Age)
        {
            Age = Age + 5;
        }

        // byOutput method receives one reference varaible and two out variables
        private void byOutput(ref int Age, out String Name, out double Salary)
        {
            Age = Age + 5;
            Name = "Ruby Locke";
            Salary = 50000.00;
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            try
            {
                // get age enter in box
                // age is passed as an argument to Age variable i the btnValue method
                // btnValue method adds 5 to Age local variable
                //  since argument is passed by value only Age (local) value
                //  changes age value stays the same:  age = Age
                int age = int.Parse(tbEnterAge.Text);
                byValue(age);   // calling byValue Method

                MessageBox.Show("Your age is: " + age.ToString() + 
                    "\nYou are passing argument by value." + 
                    "\nA copy of the varible is passed" + 
                    "\nTwo different memory locations");
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter an integer!");
            }
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(tbEnterAge.Text);

                // age = Age + 5
                byReference(ref age);

                MessageBox.Show("Your age is: " + age.ToString() +
                    "\nYou are passing argument by reference." +
                    "\nThe varaible is modified." +
                    "\nSame memory locations");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter an integer");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(tbEnterAge.Text);
                string name;
                double salary;
                byOutput(ref age, out name, out salary);

                MessageBox.Show("Your age is: " + age.ToString() +
                    "\nYou are passing output argument." +
                    "\nIt is similar to pass by reference." +
                    "\nThe name is passed as an output is: " + name +
                    "\nThe salary is passed as an output is: " + salary);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter an integer");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEnterAge.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
