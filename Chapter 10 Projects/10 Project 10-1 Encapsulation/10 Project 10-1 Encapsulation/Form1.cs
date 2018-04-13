using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Project_10_1_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Variable declaration
            double a, b;

            // Storing the input of textboxes in variables a and b
            // Converting string to double using TryParse method
            double.TryParse(tbFirst.Text, out a);
            double.TryParse(tbSecond.Text, out b);

            // Creating an instance of class Encapsulation
            // Passing a and b as arguments to the parameters of the constructor
            Encapsulation encap = new Encapsulation(a, b);

            /*
            you will et error if you enable the line below.
            Set property is disable, so the field is read-only.
            If you enable set property and hover over the line below
            after uncommenting it, you will see that is is read-only
            */
            // encap.Total = 80;

            MessageBox.Show("The sum is: " + encap.Total.ToString(), "Sum");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the form
            tbFirst.Text = "";
            tbSecond.Text = "";
        }
    }
}
