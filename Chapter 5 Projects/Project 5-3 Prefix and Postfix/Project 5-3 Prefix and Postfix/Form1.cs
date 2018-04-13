using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_3_Prefix_and_Postfix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbNumberOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            /* Prefix (++1) means the variable is incremented before it is 
               assigned to another variable or used again in the program */

            /* Exception is handled for prefix button
               you can enter any value in the tbEnter textbox */
            try
            {
                // convert to string to int
                // assigned the value entered in the tbEnter textbox
                int i = int.Parse(tbEnter.Text);

                // prefix means x is increment by 1 then assigns that to j
                int j = ++i;
                lbNumberOutput.Text = j.ToString();
            }
            catch
            {
                MessageBox.Show("Show integers only!");
            }
        }

        private void btnPostfix_Click(object sender, EventArgs e)
        {
            /* 
               Postfix (i++) means the variable is assigned to 
               another variable or used in the program before
               it gets incremented
            */
            try                       // put a try-catch to prevent program from crashing
            {
                // convert to string to int
                // assigned the value entered in the tbEnter textbox
                int i = int.Parse(tbEnter.Text);

                // postfix means x is assign to j then increment by 1 
                int j = i++;
                lbNumberOutput.Text = j.ToString();
            }
            catch
            {
                MessageBox.Show("Show integers only!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            tbEnter.Text = "";
            lbNumberOutput.Text = "";

            // Set the focus
            tbEnter.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Clear the form
            this.Close();
        }
    }
}
