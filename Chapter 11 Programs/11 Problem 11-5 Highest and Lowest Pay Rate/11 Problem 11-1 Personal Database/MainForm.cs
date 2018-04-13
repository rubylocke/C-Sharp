using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Problem_11_1_Personal_Database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void btnHighestPay_Click(object sender, EventArgs e)
        {
            // variable to store highest pay rate
            decimal maxPay;
            
            // Calling the HighestPayRate method that returns the maximum salary
            maxPay = (decimal)this.employeeTableAdapter.HighestPayRate();

            // Display the highest pay rate
            MessageBox.Show("The Highest Pay Rate is " + maxPay.ToString("c"));
        }

        private void btnLowestPayRate_Click(object sender, EventArgs e)
        {
            // variable to store highest pay rate
            double minPay;

            // Calling the HighestPayRate method that returns the maximum salary
            minPay = (double)this.employeeTableAdapter.LowestPayRate();

            // Display the highest pay rate
            MessageBox.Show("The Lowest Pay Rate is " + minPay.ToString("c"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
