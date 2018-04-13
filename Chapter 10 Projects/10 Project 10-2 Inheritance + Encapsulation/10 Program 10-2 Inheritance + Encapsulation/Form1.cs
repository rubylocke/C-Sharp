using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_10_2_Inheritance___Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            // internal variables
            decimal initialBalance, deposits, withdrawals;

            decimal.TryParse(tbInitialBalance.Text, out initialBalance);
            decimal.TryParse(tbDeposits.Text, out deposits);
            decimal.TryParse(tbWithdrawals.Text, out withdrawals);

            // Creating instance of Accounts class
            Accounts acc = new Accounts(initialBalance, deposits, withdrawals);

            // Creating instand of Checking class
            Checking chk = new Checking(initialBalance, deposits, withdrawals);

            MessageBox.Show("Accounts class info: ");
            acc.newBalance(initialBalance, deposits, withdrawals);

            MessageBox.Show("Checking class info: ");
            chk.newBalance(initialBalance, deposits, withdrawals);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            tbInitialBalance.Text = "";
            tbDeposits.Text = "";
            tbWithdrawals.Text = "";

        }
    }
}
