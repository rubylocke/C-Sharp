using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_P_12_Calculating_the_Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNumberEntered_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                // variables
                int inputNumber;      // To hold the number inputted
                double factor = 1;    // To hold end result of factor

                inputNumber = int.Parse(tbNumberEntered.Text);

                if (inputNumber < 1)
                {
                    lblOutputFactorial.Text = "Number has to be Positive";
                }
                else
                {
                    if (inputNumber > 170)
                    {
                        lblOutputFactorial.Text = "Number too large to show Factoring";
                    }
                    else
                    {
                        for (int i = 1; i <= inputNumber; i++)
                        {
                            factor = factor * i;
                        }

                        lblOutputFactorial.Text = factor.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input and output boxes
            tbNumberEntered.Text = "";
            lblOutputFactorial.Text = "";

            // Put the focus on the Number Entered Textbox
            tbNumberEntered.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
