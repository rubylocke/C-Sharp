using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Problem_8_Prime_Numbers
{
    public partial class formPrimeNumbers : Form
    {
        public formPrimeNumbers()
        {
            InitializeComponent();
        }

        // check to see if number is a prime number
        // that is, if is divisble by two with no remainder
        private bool primeNumber(int num)
        {
            // declare primeNumber boolean variable
            bool isPrimeNumber;

            // Check if the number is a prime
            //   if there is no remainder (%=0), then it is a prime number
            if (num % 2 == 0)
            {
                isPrimeNumber = false;
                lblOutputPrimeIndicator.Text = "Number is NOT Prime";
            }
            else
            {
                isPrimeNumber = true;
                lblOutputPrimeIndicator.Text = "Number is Prime";
            }
            return isPrimeNumber;
        }

        private void btnPrimeChecker_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(tbEnterNumber.Text);
                bool result = primeNumber(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Number is not valid. Enter an integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEnterNumber.Text = "";
            lblOutputPrimeIndicator.Text = "";

            // Set the focus to the tbEnterNumber
            tbEnterNumber.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
