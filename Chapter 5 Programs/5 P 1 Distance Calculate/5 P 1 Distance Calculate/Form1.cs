using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_P_1_Distance_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblHoursEnter_Click(object sender, EventArgs e)
        {

        }

        private void tbHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare variables need to display and calculate distance
            double speed, time, distance;

            // Get variables inputted
            if (double.TryParse(tbSpeed.Text, out speed))
            {
                if (double.TryParse(tbHours.Text, out time))
                {
                    // Calculate distance travelled for given speed and time
                    distance = speed * time;
                    lbOutput.Items.Add("After hour " + time + " the distance is " + distance);
                }
                else
                {
                    // Display an error message for Hours Enter
                    MessageBox.Show("Please Enter numeric data for Hours");
                }
            }
            else
            {
                // Display an error message for Speed Enter
                MessageBox.Show("Please Enter numeric data for Speed");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input boxes
            tbSpeed.Text = "";
            tbHours.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            // Clear the input boxes
            tbSpeed.Text = "";
            tbHours.Text = "";

            // Clear the output box
            lbOutput.Items.Clear();
        }
    }
}
