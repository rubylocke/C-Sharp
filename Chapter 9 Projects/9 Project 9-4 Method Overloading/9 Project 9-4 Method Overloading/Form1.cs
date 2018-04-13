using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_4_Method_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverloadInt1_Click(object sender, EventArgs e)
        {
            int a;

            //  int a holds the input of tbEnterFirst
            int.TryParse(tbEnterFirst.Text, out a);

            // Creating an instance of Method_Overloading class
            Method_Overloading mo = new Method_Overloading();

            // Calling Add method that has one parameter
            mo.Add(a);
        }

        private void btnOverloadInt2_Click(object sender, EventArgs e)
        {
            int a, b;
            
            //  int a holds the input of tbEnterFirst
            int.TryParse(tbEnterFirst.Text, out a);

            //  int a holds the input of tbEnterLast
            int.TryParse(tbEnterIntLast.Text, out b);

            // Creating an instance of Method_Overloading class
            Method_Overloading mo = new Method_Overloading();

            // Calling Add method that has one parameter
            mo.Add(a,b);
        }

        private void btnOverloadStr1_Click(object sender, EventArgs e)
        {
            string x;

            x = tbEnterFirst.Text;

            Method_Overloading mo = new Method_Overloading();

            // Add method here takes one string parameter
            mo.Add(x);
        }

        private void btnOverloadStr2_Click(object sender, EventArgs e)
        {
            string x, y;

            x = tbEnterFirst.Text;
            y = tbEnterIntLast.Text;

            Method_Overloading mo = new Method_Overloading();

            // Add method here takes one string parameter
            mo.Add(x, y);
        }
    }
}
