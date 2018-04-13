using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        // declare state and county tax as constants
        const double STATE_TAX  = 0.04;
        const double COUNTY_TAX = 0.02;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void amountPurchaseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double stateSalesTax = 0, countySalesTax = 0, totalSalesTax = 0;
            double totalSales = 0;

            // calculate the sales tax
            stateSalesTax  = STATE_TAX * double.Parse(amountPurchaseTextBox.Text);
            countySalesTax = COUNTY_TAX * double.Parse(amountPurchaseTextBox.Text);
            totalSalesTax  = stateSalesTax + countySalesTax;

            // Calculate the total sale
            totalSales = double.Parse(amountPurchaseTextBox.Text) + totalSalesTax;
                        
            // Display the sales tax
            stateSalesTaxLabel.Text = stateSalesTax.ToString();
            countyTaxLabel.Text = countySalesTax.ToString();
                        
            // Display the total sales tax
            totalSalesTaxLabel.Text = totalSalesTax.ToString();

            // Display the total sales (including sales tax)
            totalSalesLabel.Text = totalSales.ToString("c");
         }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes
            amountPurchaseTextBox.Text = "";
            
            // Clear the results labels
            stateSalesTaxLabel.Text = "";
            countyTaxLabel.Text     = "";
            totalSalesTaxLabel.Text = "";
            totalSalesLabel.Text    = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void totalSalesTaxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
