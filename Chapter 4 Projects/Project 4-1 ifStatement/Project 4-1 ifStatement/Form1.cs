using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_1_ifStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEnterGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnGtGrade_Click(object sender, EventArgs e)
        {
            /* convert the input of tbGrade textbox to from string to 
               double and storing the value in grade variable */
            double grade = double.Parse(tbGrade.Text);

            // beginning if statements
            if (grade >= 90)
            {
                lblLetterGrade.Text = "A";
            }
            else if (grade >= 80)
            {
                lblLetterGrade.Text = "B";
            }
            else if (grade >= 70)
            {
                lblLetterGrade.Text = "C";
            }
            else if (grade >= 60)
            {
                lblLetterGrade.Text = "D";
            }
            else 
            {
                lblLetterGrade.Text = "F";
            }
            // end if

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls
            tbGrade.Text = "";
            lblLetterGrade.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
