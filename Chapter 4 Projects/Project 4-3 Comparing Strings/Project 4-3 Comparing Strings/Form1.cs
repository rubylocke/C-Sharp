using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_3_Comparing_Strings
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
            tbFirstString.Text = "";
            tbSecondString.Text = "";

            lblEqual.Text = "";
            lblUnEqual.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnCompare1_Click(object sender, EventArgs e)
        { 
            string str1, str2;              // To hold strings
            
            // Get the strings
            str1 = (tbFirstString.Text); 
            str2 = (tbSecondString.Text);

            if (str1 == str2)
            {
                lblEqual.Text = "Strings are equal";
                lblUnEqual.Text = "";
                MessageBox.Show("Strings are equal!");
            }
            else
            {
                lblEqual.Text = "";
                lblUnEqual.Text = "Strings are not equal";
                MessageBox.Show("Strings are not equal!");
            }
        }

        private void btnCompare2_Click(object sender, EventArgs e)
        {
            string str1, str2;              // To hold strings

            // Get the strings
            str1 = (tbFirstString.Text);
            str2 = (tbSecondString.Text);

            int result = string.Compare(str1, str2);
            lblEqual.Text = "";
            lblUnEqual.Text = result.ToString();
            MessageBox.Show(result.ToString());
        }
    }
}
