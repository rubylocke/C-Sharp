using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayElementsButton_Click(object sender, EventArgs e)
        {
            // creating a string array with three elements
            string[] strArr = { "Ali Dayoub", "Sean King", "Adam Smith" };
            string s1 = strArr[0];
            string s2 = strArr[1];
            string s3 = strArr[2];

            // display the elements of the array on messageboxes
            MessageBox.Show(s1, "First Element");
            MessageBox.Show(s2, "Second Element");
            MessageBox.Show(s3, "Third Element");
        }

        private void gnerateExceptionButton_Click(object sender, EventArgs e)
        {
            string[] strArr = { "Ali Dayoub", "Sean King", "Adam Smith" };
            // messagebox indicating the program about to crash
            MessageBox.Show("Your program about to crash");
            string s = strArr[3];
        }

        private void catchTheExceptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                /* try block tries the code below. If there is an exception
                   it will jump to catch block and execute it */
                string[] strArr = { "Ali Dayoub", "Sean King", "Adam Smith" };
                string s = strArr[3];
            }
                /* exception variable named ex
                   The Exception will be equal to the Exception thrown */
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error!");
            }
        }
    }
}
