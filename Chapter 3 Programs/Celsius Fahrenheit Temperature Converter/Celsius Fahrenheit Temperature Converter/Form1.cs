using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_Fahrenheit_Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void calculateConversionButton_Click(object sender, EventArgs e)
        {
            double fahrenheit  = 0;
            double temperature = double.Parse(enterTemperatureTextBox.Text);

            // conversion formula
            fahrenheit = ((9 / 5) * temperature) + 32;

            // Display Fathrenheit temperature
            conversionTextBox.Text = string.Format("{0}\u00B0F", fahrenheit);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear textbox values
            enterTemperatureTextBox.Text = "";

            // Clear result value
            conversionTextBox.Text = "";
        }

        private void calculateCelsiusFahrenheitButton_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            double temperature = double.Parse(enterTemperatureTextBox.Text);

            // conversion formula
            celsius = (5 / 9) * (temperature - 32);

            // Display Celsius temperature
            conversionTextBox.Text = string.Format("{0}\u00B0C", celsius);
        }
    }
}
