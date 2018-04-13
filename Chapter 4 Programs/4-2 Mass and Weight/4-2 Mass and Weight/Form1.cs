using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_2_Mass_and_Weight
{
    public partial class Form1 : Form
    {

        const double TOO_LARGE = 1000;
        const double TOO_LIGHT = 10;
        const double CONV_RATE_WEIGHT_TO_MASS = 9.8;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateWeight_Click(object sender, EventArgs e)
        {
            double mass = 0;    // To hold the object's mass
            double weight = 0;  // To hold the object weight

            // reset the calculate field
            lblWeight.Text = "";

            if (double.TryParse(tbMass.Text, out mass))
            {
                // Caculate the weight
                weight = mass * CONV_RATE_WEIGHT_TO_MASS;

                // Display the weight
                lblWeight.Text = weight.ToString("n1");

                // Is the object too heavy?
                if (weight > TOO_LARGE)
                {
                    MessageBox.Show("The object is too heavy.");
                }

                // Is the object too light
                if (weight < TOO_LIGHT)
                {
                    MessageBox.Show("The object is too light.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the Form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the texboxes
            tbMass.Text    = "";

            // Clear the output textbox
            lblWeight.Text = "";
        }
    }
}
