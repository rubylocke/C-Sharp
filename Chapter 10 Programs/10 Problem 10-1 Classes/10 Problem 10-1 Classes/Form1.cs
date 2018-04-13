using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Problem_10_1_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            // Create an instance
            ProductionWorker worker = new ProductionWorker();

            // get info from textboxes
            worker.Name = tbEmployeeName.Text;
            worker.Number = tbEmployeeNumber.Text;
            worker.PayRate = decimal.Parse(tbHourlyPayRate.Text);
            if (rbDayShift.Checked)
            {
                worker.Shift = 1;
            }
            else
            {
                worker.Shift = 2;
            }

            // Retrieve class
            lblOutName.Text = worker.Name;
            lblOutNumber.Text = worker.Number;
            lblOutRate.Text = worker.PayRate.ToString("c");
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
