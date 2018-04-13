using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Problem_8_8_Sum_of_Numbers_in_a_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;   // accumulator
            double y;           // variable to TryParse value into

            // Get the user's input and put in a string variable
            string str = tbStringOfNumbers.Text;

            // Create a delimiter "comma" array
            char[] delim = { ',' };

            // Tokenize the user's input:
            //   put into an string array each number broken by ","
            string[] tokens = str.Split(delim);
            
            // Calculate the total of the numbers by using foreach
            foreach (string s in tokens)
            {
                // is token valid numeric
                if (double.TryParse(s, out y))
                {
                    total += y;
                }
                else
                {
                    MessageBox.Show(s + " is not a number. Will not be included in Sum.");
                }
            }

            // Display the total
            lblOutputSum.Text = total.ToString("n1");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
