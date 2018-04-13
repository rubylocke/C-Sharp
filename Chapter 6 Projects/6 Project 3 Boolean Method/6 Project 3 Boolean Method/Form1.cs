using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Project_3_Boolean_Method
{
    public partial class formBoolean : Form
    {
        public formBoolean()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // evenOrOdd method receives an integer argument and returns a boolean value
        private bool evenOrOdd(int num)
        {
            // Declaring is evenOrOdd boolean variable
            bool isEvenOrOdd;

            // checking if the number is divided by 2 has a remainder
            if (num % 2 == 0)
            {
                // if the remainder is 0, the number is even
                isEvenOrOdd = true;

                MessageBox.Show("The number is even.");
            }
            else
            {
                // if there is remainder is not 0, the number is ood
                isEvenOrOdd = false;
                MessageBox.Show("The number is odd.");
            }
            return isEvenOrOdd;
        }

        private void btnEvenOrOdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(tbInteger.Text);
                // storing the return value of evenOrOdd method
                // in result boolean variable

                bool result = evenOrOdd(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the textbox
            tbInteger.Text = "";

            // set the focus on the textbox
            tbInteger.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
