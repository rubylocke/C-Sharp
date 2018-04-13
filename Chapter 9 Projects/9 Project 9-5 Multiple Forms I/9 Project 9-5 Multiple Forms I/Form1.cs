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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            string firstName, lastName;

            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;

            // Creating an instance of class Form2
            Form2 f2 = new Form2(firstName, lastName);

            // Using Show method in Form2 class to display modeless, you can go to any form
            f2.Show();

            // modal, only the last form has the focus and must be closed 
            //    before you get to other form(s)
            // f2.ShowDialog();

        }
    }
}
