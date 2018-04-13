using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_4_Using_Generating_Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generating Random Numbers

            // Declaring randomNumber variable of type int
            int randomNumber = 0;

            // Creating an instance rnd of Random class
            Random rnd = new Random();

            /* Calling the Next Function in Random class
               1 is the minValue; 50 is the maxValue   */
            randomNumber = rnd.Next(1, 50);

            // Display the randomNumber(s) on the label (lbGeneratedNumbers)
            lbGeneratedNumbers.Text = randomNumber.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbGeneratedNumbers.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
