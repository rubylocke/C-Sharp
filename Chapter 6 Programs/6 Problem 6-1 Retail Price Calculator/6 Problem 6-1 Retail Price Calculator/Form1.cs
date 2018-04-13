using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Problem_6_1_Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        private const decimal PERCENT_CONVERSION = 0.01m;

        public Form1()
        {
            InitializeComponent();
        }

        // CalculateRetailPrice will receive the wholesale price and retail percentage
        // and returns the retail price
        private decimal CalculateRetailPrice(decimal whole, decimal retailMarkup)
        {
            decimal price;
            price = whole + (whole * retailMarkup);  
            return price;
        }

        // Validate input
        private bool InputIsValid(ref decimal whole, ref decimal retailMarkup)
        {
            // Flag to indicate whether the input is good
            bool inputGood = false;

            // try to convert inputs
            if (decimal.TryParse(tbWholeSale.Text, out whole))
            {
                if (decimal.TryParse(tbMarkUp.Text, out retailMarkup))
                {
                    inputGood = true;
                }
                else
                {
                    // Display an error message
                    MessageBox.Show("Markup is invalid");
                }
            }
            else
            {
                // Display an error message
                MessageBox.Show("Wholesale costis invalid");
            }
            return inputGood;
        }

        private void btnCalculateRetailPrice_Click(object sender, EventArgs e)
        {
            // variables for wholesale cost, retail percentage, and Retail price
            decimal wholesale = 0m, retail = 0m;
            decimal retailPercentage= 0.0m;

            if (InputIsValid(ref wholesale, ref retailPercentage))
            {
                retailPercentage = retailPercentage * PERCENT_CONVERSION;
                retail = CalculateRetailPrice(wholesale, retailPercentage);
                lblOutputRetailPrice.Text = retail.ToString("n1");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Input
            tbWholeSale.Text = "";
            tbMarkUp.Text = "";
            
            // Output 
            lblOutputRetailPrice.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
