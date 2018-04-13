using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_5_TryParse__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            // Parse method converts string to numeric value.
            int i = Int32.Parse(tbEnterInteger.Text);
            MessageBox.Show(i + ", is converted from string to numeric.");
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            /*  TryParse method returns the actual value if the conversion
                from string to numeric is successful.
                It returns 0 if the conversion is unsuccessful  */
            string str = (tbEnterAlphanumeric.Text);
            int result = 0;
            int.TryParse(str, out result);
            MessageBox.Show("The conversion value is: " + result);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
