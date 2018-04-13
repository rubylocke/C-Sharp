using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_5_Multiple_Forms_I
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGoToForm1_Click(object sender, EventArgs e)
        {
            // Creating object of form1
            MainForm f1 = new MainForm();

            // Using Show method in Form1 class
            f1.Show();
        }

        // Form2 method takes parameters
        // Argument are passed from Form1
        public Form2(string fn, string ln)
        {
            InitializeComponent();

            lblCaption.Text = "";
            lblCaption.Text = "Hello, " + fn + " " + ln;
        }
    }
}
