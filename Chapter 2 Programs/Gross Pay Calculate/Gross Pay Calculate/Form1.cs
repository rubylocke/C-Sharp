using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gross_Pay_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Calculate the Gross Pay
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declaration of variables
            double hoursWorked, hourlyPayRate, grossPay;

            /** retrieve the hours worked and pay rate
                Any value entered in a textbox is treated as a string
                Converting string to double */
            hoursWorked   = double.Parse(hoursWorkedtextBox.Text);
            hourlyPayRate = double.Parse(hourlyPayRateTextBox.Text);

            // calculate pay and display
            grossPay = hoursWorked * hourlyPayRate;
            /**  label can output strings only
                 Converting double to string
                 C means currency */
            grossPayCalculatedLabel.Text = grossPay.ToString("c");

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxs
            hoursWorkedtextBox.Text   = "";
            hourlyPayRateTextBox.Text = "";

            // Clear the output values
            grossPayCalculatedLabel.Text = "";
        }
    }
}
