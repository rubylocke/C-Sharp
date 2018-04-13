using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_P_3_Celsius_To_Fahrenheit_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create variables to hold Celsius and Fahrenheit
            double celsius, fahrenheit;

            // Put displays in your output to show what you are displaying
            lbCeltoFah.Items.Add("Celsius\tFahrenheit");

            // for loop
            // Display the conversion of celsisus to fahrenheit for the first 21
            for (celsius = 0; celsius  <= 20; celsius ++)
            {
                fahrenheit = ((9.0 / 5.0) * celsius) + 32;

                // display the output
                lbCeltoFah.Items.Add(celsius + "\t" + fahrenheit);
            }
        }
    }
}
