using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_1_While_and_Do_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDwhileFW_Click(object sender, EventArgs e)
        {
            // loop control varaible
            int i = 1;

            // loop condition below is checked before executing any statement
            while (i <= 10)
            {
                // as long as i is <= 10 increment i by 1 and
                // add an item to iteration listbox with every iteration
                lbIteration.Items.Add("Iteration: " + i.ToString());

                // increment i by 1  i+=1 is the ame as i=i+1 and as i++
                i++;
            }
        }

        private void btnWhileBW_Click(object sender, EventArgs e)
        {
            // loop control varaible
            int i = 10;

            // loop condition below is checked before executing any statement
            while (i > 0)
            {
                // add itme to iteration Listbox every iteration
                lbIteration.Items.Add("Iteration: " + i.ToString());

                // decrement i by 1 
                 i -=1;
            }
        }

        private void btnDoWhileFW_Click(object sender, EventArgs e)
        {
            // loop control varaible
            int counter = 1;

            do
            {
                // statement is executed before loop condition is checked
                lbNumbers.Items.Add(counter);
                // loop condition
                counter = counter + 1;
            } while (counter < 10);
        }

        private void btnDoWhileBW_Click(object sender, EventArgs e)
        {
            // loop control varaible
            int counter = 10;

            do
            {
                // statement is executed before loop condition is checked
                lbNumbers.Items.Add(counter);
                // loop condition
                counter--;
            } while (counter > 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear list boxes
            lbIteration.Items.Clear();
            lbNumbers.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
