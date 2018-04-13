using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Problem_10_2_ShiftSupervisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // successful, the method returns true. Otherwise it returns false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            // Flag variable to indicate whether the input is good
            bool inputGood = false;
            if (string.IsNullOrWhiteSpace(tbEntBonus.Text))
            {
                bonus = 0;
            }
            // Try to convert both inputs to decimal
            if (decimal.TryParse(tbEntSalary.Text, out pay))
            {
                if (string.IsNullOrWhiteSpace(tbEntBonus.Text))
                {
                    bonus = 0;
                    inputGood = true;
                }
                else if (decimal.TryParse(tbEntBonus.Text, out bonus))
                {
                    // Both inputs are good
                    inputGood = true; 
                }
                else
                {
                    // Display an error message for the bonus
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                // Display an error message for gross pay.
                MessageBox.Show("Annual Salary is invalid.");
            }
            // Return the result
            return inputGood;
        }


        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            // Create some internal fields for conversion of decimals
            decimal bonus=0m, salary=0m;
            
            // Create an instance
            ShiftSupervisor worker = new ShiftSupervisor();

            // get info from textboxes
            worker.Name = tbEntName.Text;
            worker.Number = tbEntNumber.Text;
            worker.PayRate = decimal.Parse(tbEntHourlyPayRate.Text);

            if (InputIsValid(ref salary, ref bonus))
            {
                worker.Salary = salary;
                worker.Bonus = bonus;
            }
                       
            if (rbEntNights.Checked)
            {
                worker.Shift = 2;
            }
            else
            {
                worker.Shift = 1;
            }

            // Retrieve class
            lblOutName.Text = worker.Name;
            lblOutNumber.Text = worker.Number;
            lblOutRate.Text = worker.PayRate.ToString("c");
            lblOutSalary.Text = worker.Salary.ToString("c");
            lblOutBonus.Text = worker.Bonus.ToString("c");
            if (worker.Shift == 1)
            {
                lblOutShift.Text = "Day";
            }
            else
            {
                lblOutShift.Text = "Night";
            }

        }
    }
}
