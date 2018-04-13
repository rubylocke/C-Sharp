using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_10_2_Inheritance___Encapsulation
{
    // base class Accounts
    class Accounts
    {
        // Backing Fields
        // Decimal has more precision than double
        private decimal _balance;
        private decimal _deposits;
        private decimal _withdrawals;

        // Constructor with three parameters
        public Accounts(decimal Balance, decimal Deposits, decimal Withdrawals)
        {
            _balance = Balance;
            _deposits = Deposits;
            _withdrawals = Withdrawals;
        }

        // newBalance method that receives Balance, Deposits, and Withdrawals
        public void newBalance(decimal Balance, decimal Deposits, decimal Withdrawals)
        {
            decimal newBal = Balance + Deposits - Withdrawals;

            MessageBox.Show("Initial balance is: " + Balance.ToString("C") +
                "\n\nDeposit amount is: " + Deposits.ToString("C") +
                "\n\nWithdraw amount is: " + Withdrawals.ToString("C") +
                "\n\nNew Balance is: " + newBal.ToString("C"));
        }
        
    }
}
