using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_1_Classes_I
{
    public partial class frmClassesI : Form
    {
        public frmClassesI()
        {
            InitializeComponent();
        }

        private void frmClassesI_Load(object sender, EventArgs e)
        {

        }

        private void btnClassDefault_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the default constructor for the Customer Class!" +
                "\nClasss fields here are initialized by displayCustomerInfo method" +
                "\nDefault values are: string = null, int= 0, double =0.0");
            //The default constructor
            Customer Cust1 = new Customer();
            Cust1.displayCustomerInfo();
        }

        private void btnDefaultParaConstructor_Click(object sender, EventArgs e)
        {
            // Creating an instance (object) of Employee class
            // Passing arguments to the parameterized constructor
            // Calling the constructor with 4 parameters
            Employee Emp = new Employee("Ruby", "Locke", 102, 54);

            // Default constructor
            Employee Emp1 = new Employee();

            // Calling displayEmployeeInfo method
            Emp.displayEmployeeInfo();
            Emp1.displayEmployeeInfo();
        }

        private void btnOverloadConst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling the constructor with 3 parameters");
            // E1 object calls only the constructor with 3 parameters
            Employee E1 = new Employee("Sarah", "Jones", 300);

            MessageBox.Show("Calling the constructor with 1 parameter");
            // E2 object calls only the constructor with 1 parameter
            Employee E2 = new Employee("Matt");

            // Calling the display method
            E1.displayEmployeeInfo();
            E2.displayEmployeeInfo();
        }

        private void btnDefaultConstEmpl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the default constructor for the Employee Class!" +
               "\nIt will initializes the class fields to deafult values" +
               "\nDefault values are: string = null, int= 0, double =0.0");

            //The default constructor initializes the class fields to default values
            Employee E = new Employee();

            // Calling the displayEmployeeInfo method
            E.displayEmployeeInfo();
        }
    }
}
