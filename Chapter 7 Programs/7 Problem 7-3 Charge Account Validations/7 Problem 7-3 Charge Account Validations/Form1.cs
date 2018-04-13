using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7_Problem_7_3_Charge_Account_Validations
{
    public partial class Form1 : Form
    {
        const int SIZE = 18;     // SIZE of array
        // Array to hold the charge account nubmers
        public int[] acctNumbers = new int[SIZE];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = 0;           // index of array
                        
            // Open the file
            StreamReader inputFile = File.OpenText("ChargeAccounts.txt");

            // Read the contents of the file into an array
            while (!inputFile.EndOfStream && index < acctNumbers.Length)
            {
                acctNumbers[index] = int.Parse(inputFile.ReadLine());
                index++;
            }
        }

        // Searches for an account number
        // 
        private bool searchAcct(int[] acctNumbers, int acct1)
        {
            int index = 0;          //  Used to step through the array
            bool found = false;     // 

            while (!found && index < acctNumbers.Length)
            {
                if (acctNumbers[index] == acct1)
                {
                    found = true;
                 }
                 // Increment index
                 index++;
            }
            return found;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int acct;               // To hold the charge account number entered in the textbox
            // int index = 0;          //  Used to step through the array
                
            if( int.TryParse(tbAcctNumber.Text, out acct))
            {
                if (searchAcct(acctNumbers, acct))
                {
                    MessageBox.Show("Charge Account is Valid");
                }
                else
                {
                    MessageBox.Show("Charge Account is NOT Valid");
                }
            }
            else
            {
                // Dispaly invalid number entered
                MessageBox.Show("Enter an numeric number for Charge Account");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input
            tbAcctNumber.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
