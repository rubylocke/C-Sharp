using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Problem_11_4_Use_SQL_for_Retrieval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void btnSortByDept_Click(object sender, EventArgs e)
        {
            // Calling FillByDepartment method
            // the method sorts the table by Department in Ascending Order
            this.employeeTableAdapter.FillByDepartment(this.employeeDataSet.Employee);
        }

        private void btnSalGR40000_Click(object sender, EventArgs e)
        {
            // Calling FillBySalary method
            // this method returns the Salaries that are greater than 40 k
            this.employeeTableAdapter.FillBySalary(this.employeeDataSet.Employee);
        }

        private void btnAvgSal_Click(object sender, EventArgs e)
        {
            // Declare a variable to store the Average Salary value
            double avgSalary;

            // Converting (casting) the average to double
            // This method returns the average salary
            avgSalary = (double)this.employeeTableAdapter.AverageSalary();

            MessageBox.Show("The Average Salary is " + avgSalary.ToString(), "Average Salary!");
        }

        private void btnMinSalary_Click(object sender, EventArgs e)
        {
            // Declare a variable to store the Minimum Salary value
            double minSalary;

            // Converting (casting) the minimum Salary to double
            // This method returns the minimum salary
            minSalary = (double)this.employeeTableAdapter.MinimumSalary();

            MessageBox.Show("The Lowest Salary is " + minSalary.ToString(), "Minimum Salary!");
        }

        private void btnMaxSal_Click(object sender, EventArgs e)
        {
            // Declare a variable to store the Maximum Salary value
            double maxSalary;

            // Converting (casting) the maximum salary to double
            // This method returns the maximum salary
            maxSalary = (double)this.employeeTableAdapter.MaximumSalary();

            MessageBox.Show("The Highest Salary is " + maxSalary.ToString(), "Maximum Salary!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Calling the SearchLastName Method that takes teh value entered in the 
            // tbSearchValue textbox as an argument
            this.employeeTableAdapter.SearchLastName(this.employeeDataSet.Employee, tbSearchValue.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Calling the Fill method to populate the table with data
            // This method returns all rows in Employee table
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }
    }
}
