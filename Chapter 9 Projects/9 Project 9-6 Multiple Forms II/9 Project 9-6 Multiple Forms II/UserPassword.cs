using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_6_Multiple_Forms_II
{
    public partial class UserPassword : Form
    {
        public UserPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("User created!");
        }
    }
}
