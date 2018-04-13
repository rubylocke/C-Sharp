using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Project_1_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare two global variables:  avaiable to all class methods
        int globala, globalb;


        // add() method does not receive anything directly or return (void) anything
        // It can act on global variables
        // When it is called, it returns:
        //    1) the sume of 5 + 10 (local to this method only)
        //    2) the sum of the values stored in the global variables a & b, 
        //       passed from btnVoidMethod1
        // Add method pass the result of its calculation to bnVoidMethod1 method
        //  if no access modifier is present, then its private by default
        void add()
        {
            int x = 5;         // x is a local variable
            int y = 10;        // y is a local variable
            int sum = x + y;   // sum is a local variable
            // c is a local variable that holds the sum of global variables globala & globalb
            int c = globala + globalb;

            // Display the sums on messageboxes
            //   \n starts new line
            MessageBox.Show("This method adds 5 + 10 = " + sum + "\n\nAlso adds "
                + globala + " + " + globalb + " = " + c);
            // converting sum to string
            MessageBox.Show(sum.ToString());
            MessageBox.Show(c.ToString());
            // Convert the sums to a string and display it on a label
            lblResult.Text = sum.ToString() + ", " + c.ToString();
        }

        // Multiple Method does not return any value (void)
        // int l & int m are the method parameters
        //    They receive arguments passed from the calling method
        //    In this case, btnVoidMethod2
        // The method multiples (l * m) and stores the result in a q variable
        void multiply (int l, int m)
        {
            // stores the product of (l*m) in q
            // l and m are passed from the calling method
            int q = l * m;

            // display the product on a messagebox
            MessageBox.Show(globala + " * " + globalb + " = " + q);
            // Display the product on a label
            lblResult.Text = globala.ToString() + " * " + globalb.ToString() + " = " + q.ToString();
        }

        // Subtract Method receives two numbers and returns a value of difference
        //   btnReturnValue calls this method
        // l & m are the method parameters.  They receive arguments from btnReturnValue
        int subtract(int l, int m)
        {
            // storing the difference between l & m in f variable
            int f = l - m;
            // return f
            return f;
        }

        private void btnVoidMethod1_Click(object sender, EventArgs e)
        {
            // try catch block to catch any invalid inut entered in tbFirstNumber & tbSecondNumber
            try
            {
                globala = int.Parse(tbFirstNumber.Text);   // convert string to int
                globalb = int.Parse(tbSecondNumber.Text);  // convert string to int
                add();                               // calling add method
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter an integer ");
            }
        }

        private void btnReturnValue_Click(object sender, EventArgs e)
        {
            // try to catch block to catch any invalid input entered tbFirstNumber & tbSecondNumber
            try
            {
                // int globala and globalb are declared globally (classwide)
                // converting string to int
                globala = int.Parse(tbFirstNumber.Text);
                globalb = int.Parse(tbSecondNumber.Text);

                // the values of int globala and globalb are passed to subtract method
                // int l = globala, int m = globalb
                // globala and globalb are called arguments
                // int l and int m are called parameters: they receive arguments
                //   from the calling method btnRetrunValue method
                // subtact method: subtracts m from l
                // the result is passed to btnReturnValue method
                // then the result is store din local variable w

                int w = subtract(globala, globalb);   // calling subtract method

                // Display the result int globalb from int globala on a messagebox
                MessageBox.Show(w.ToString());

                // Display the result of subtacting int globalb from globala label
                lblResult.Text = globala.ToString() + " - " + globalb.ToString() + " = " + w.ToString();
            }
            catch
            {
                // Catch block catches any non-interger input in tbFirstNumber and tbSecondNumber
                MessageBox.Show("Invalid input. Please enter an integer");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the text boxes and the result
            tbFirstNumber.Text = "";
            tbSecondNumber.Text = "";
            lblResult.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnVoidMethod2_Click(object sender, EventArgs e)
        {
            try
            {
                globala = int.Parse(tbFirstNumber.Text);   // convert string to int
                globalb = int.Parse(tbSecondNumber.Text);  // convert string to int

                // pass globala and globalb arugument to multiple method
                // int l recieves the value of globala, l = globala
                // int m receives the value of globalb, m = globalb 

                multiply(globala, globalb);    // calling the mulitple method
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter an integer ");            }
        }

    }
}
