using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_6_Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            // Evaluate if RED Color was selected in the first set
            if (rbFirstRed.Checked)
            {
                // Evaluate which Color was selected in the second set
                if (rbSecondRed.Checked)
                {
                    this.BackColor = Color.Red;
                }
                else if (rbSecondBlue.Checked)
                {
                    this.BackColor = Color.Purple;
                }
                else if (rbSecondYellow.Checked)
                {
                    this.BackColor = Color.Orange;
                }
            }

            // Evaluate if BLUE Color was selected in the first set
            if (rbFirstBlue.Checked)
                // Evaluate which Color was selected in the second set
                if (rbSecondRed.Checked)
                {
                    this.BackColor = Color.Purple;
                }
                else if (rbSecondBlue.Checked)
                {
                    this.BackColor = Color.Blue;
                }
                else if (rbSecondYellow.Checked)
                {
                    this.BackColor = Color.Green;
                }

            // Evaluate if YELLOW Color was selected in the first set
            if (rbFirstYellow.Checked)
                // Evaluate which Color was selected in the second set
                if (rbSecondRed.Checked)
                {
                   this.BackColor = Color.Orange;
                 }
                else if (rbSecondBlue.Checked)
                {
                   this.BackColor = Color.Green;
                }
                else if (rbSecondYellow.Checked)
                {
                   this.BackColor = Color.Yellow;
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
