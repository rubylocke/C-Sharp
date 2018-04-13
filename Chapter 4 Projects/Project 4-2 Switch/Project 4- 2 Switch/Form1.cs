using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4__2_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls
            tbEnterLetter.Text = "";
            lblTextOutput.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        private void btnGetResponse_Click(object sender, EventArgs e)
        {
            /* storing the input in the tbEnterLetter textbox in 
               string variable letterGrade */
            string lettergrade = (tbEnterLetter.Text);

            switch (tbEnterLetter.Text)
            {
                case "A":
                    lblTextOutput.Text = "You made an A, great job!";
                    break;
                case "B":
                    lblTextOutput.Text = "You made an B, good job!";
                    break;
                case "C":
                    lblTextOutput.Text = "You made an C, You can do better!";
                    break;
                case "D":
                    lblTextOutput.Text = "You made an D, barely passed!";
                    break;
                case "F":
                    lblTextOutput.Text = "Sorry, you failed!";
                    break;
                default:
                    lblTextOutput.Text = "Invalid entry, please enter: A, B, C, D or F";
                    break;
            }
        }
    }
}
