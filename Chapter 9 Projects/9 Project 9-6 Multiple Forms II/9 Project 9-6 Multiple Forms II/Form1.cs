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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserPassword f2 = new UserPassword();

            f2.ShowDialog();

            lblDisplayUserName.Text = "Username : " + f2.tbUserName.Text;
            lblDisplayPassword.Text = "Password : " + f2.tbPassword.Text;
        }
    }
}
