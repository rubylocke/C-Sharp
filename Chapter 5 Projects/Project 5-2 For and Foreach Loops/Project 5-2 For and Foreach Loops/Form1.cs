using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_2_For_and_Foreach_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForEachList_Click(object sender, EventArgs e)
        {
            // Creating an integer list called numbers
            List<int> numbers = new List<int>();

            // add elements to the list
            numbers.Add(25);
            numbers.Add(70);
            numbers.Add(26);
            numbers.Add(63);
            numbers.Add(09);

            // loop thru the list and add an element to the listbox (lbNumbers) with each iteration
            foreach (int i in numbers)
            {
                lbStrings.Items.Add(i.ToString());
            } 
        }

        private void btnForBW_Click(object sender, EventArgs e)
        {
            // Counts in descending order (backward)
            for (int i = 10; i > 0; i--)
            {
                lbNumbers.Items.Add(i.ToString());
            }
        }

        private void bnForFW_Click(object sender, EventArgs e)
        {
            // Counts in ascending order (forward)

            /* for loop parameters are:
                1-the loop control variable
                2-the condition
                3-the increment/decrement */
            for (int i = 0; i < 10; i++)
            {
                // add list item with every iteration
                // Counts in ascending order by incrementing i one at a time
                //  once i equals 10, the loop terminates
                lbNumbers.Items.Add("Iterations: " + i.ToString());
            }
        }

        private void btnForEachString_Click(object sender, EventArgs e)
        {
            // For Each, string button
            // creating a string Array called names
            string[] names = { "Ali", "Charlie", "Mary", "Cathy", "Tom" };

            // loops thru the array and stores every element in ArrElem variable
            foreach (string arrElm in names)
            {
                // adds an element to the listbox with every iteration
                lbStrings.Items.Add(arrElm);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the listboxes
            lbNumbers.Items.Clear();
            lbStrings.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
