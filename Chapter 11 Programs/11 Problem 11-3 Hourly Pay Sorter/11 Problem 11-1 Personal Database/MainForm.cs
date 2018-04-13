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
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
            employeeDataGridView.Columns[0].Width = 100;
            employeeDataGridView.Columns[1].Width = 120;
            employeeDataGridView.Columns[2].Width = 100;
            employeeDataGridView.Columns[3].Width = 120;
        }

        private void btnPayAsc_Click(object sender, EventArgs e)
        {
            // Calling FillByHourPayRateAsc 
            // This method sorts the HourPayRate in Ascending Order
            this.employeeTableAdapter.FillByHourPayRateAsc(this.employeeDataSet.Employee);
        }

        private void btnPayDesc_Click(object sender, EventArgs e)
        {
            // Calling
            // This method sorts the HourPayRate in Descending Order
            this.employeeTableAdapter.FillByHourPayRateDesc(this.employeeDataSet.Employee);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
