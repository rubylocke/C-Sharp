using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Problem_10_4_Person_and_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            // Create internal usage fields
            int custNum;
            
            // Create an instance of Customer class
            Customer cust1 = new Customer();

            // Get info from form
            cust1.Name = tbName.Text;
            cust1.Address = tbAddress.Text;
            cust1.Phone = tbPhone.Text;

            if (int.TryParse(tbCustNum.Text, out custNum))
            {
                cust1.CustNo = custNum;
            }
            else
            {
                MessageBox.Show("Customer Number has to be numeric. Please reenter");
            }

            if (rbMailNo.Checked)
            {
                cust1.Mail = false;
            }
            else
            {
                cust1.Mail = true;
            }

            // Retrieve class for display
            lblOutName.Text = cust1.Name;
            lblOutAddress.Text = cust1.Address;
            lblOutPhone.Text = cust1.Phone;
            lblOutCustNo.Text = cust1.CustNo.ToString();
            if (cust1.Mail)
            {
                lblOutMail.Text = "Yes";
            }
            else
            {
                lblOutMail.Text = "No";
            }
        }
    }
}
