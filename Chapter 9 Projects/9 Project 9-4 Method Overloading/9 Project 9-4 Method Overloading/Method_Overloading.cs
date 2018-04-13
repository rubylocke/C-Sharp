using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_4_Method_Overloading
{
    class Method_Overloading
    {
        // Overload method
        // Add method has one parameter
        public int Add(int a)
        {
            // this method adds 3 to the argument passed on to it
            int x = a + 3;

            MessageBox.Show("You are calling a method with one argument." +
                "\nThis method adds 3 to the number entered in tbEnterFirst textbox");

            MessageBox.Show(a + " + 3 = " + x.ToString());
            return x;
        }

        // Add method again but with 2 parameters
        public int Add(int a, int b)
        {
            // This method add both arguments passed on to it
            int x = a + b;

            MessageBox.Show("You are calling an overloaded method with two arguments." +
                "\nThis method adds the numbers entered");

            MessageBox.Show(a + " + " + b + " = " + x.ToString());
            return x;
        }

        public string Add(string a)
        {
            string y = "Hello " + a;
            MessageBox.Show(y.ToString());
            MessageBox.Show("You are method adds Hello to the name entered in tbEnterFirst textbox");
            return y;
        }

        public string Add(string a, string b)
        {
            string yourName = a + " " + b;
            MessageBox.Show("This overloaded method returns full name");
            MessageBox.Show(yourName);
            return yourName;
        }
    }
}
