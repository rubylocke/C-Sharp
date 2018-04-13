using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_6_Enumeration
{

    //Declare the enum in the name space and outside the form
    //The datatype for enum is int by default
    // enum fields/members start at index 0. They can be manipulated
    enum weekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadMembers_Click(object sender, EventArgs e)
        {
            // Using GetName method in Enum class to get enum elemetns
            // Storing enum elements in Values string array
            string[] Values = (string[])Enum.GetNames(typeof(weekDays));

            // loop thru Values string array
            foreach (object i in Values)
            {
                // Display the elements in listbox
                lbDays.Items.Add(i);
            }
        }

        private void btnAccessAnElement_Click(object sender, EventArgs e)
        {
            // Creating an instance of enum weekDays to access one element
            weekDays wd = weekDays.Monday;

            // Creating another instance of enum WeekDays to access one element
            weekDays wd1 = weekDays.Friday;
            // Display elements
            MessageBox.Show(wd.ToString());
            MessageBox.Show(wd1.ToString());
        }

        private void btnLoadIndexes_Click(object sender, EventArgs e)
        {
            // Using GetName method in Enum class to get enum elemetns
            // Storing enum elements in Numbers int array
            int[] Numbers = (int[])Enum.GetValues(typeof(weekDays));

            // Loop thru Number int array
            foreach (int i in Numbers)
            {
                // Display indexes in listbox
                lbDaysNumbers.Items.Add(i);
            }
        }

        private void btnLoadonMB_Click(object sender, EventArgs e)
        {
            // using GetValues method inside Enum class
            // type of the enum is weekDays
            // Loop thru enum members
            foreach (weekDays wd in Enum.GetValues(typeof(weekDays)))
            {
                // Display members on messagebox
                MessageBox.Show(wd.ToString());
            }
        }
    }
}
