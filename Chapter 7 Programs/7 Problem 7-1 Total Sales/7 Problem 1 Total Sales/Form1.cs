using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7_Problem_1_Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int SIZE = 7;
            int index = 0;

            decimal totalSales = 0m;  // To hold calculated total sales

            // Array to hold the sale amounts
            decimal[] salesAmount = new decimal[SIZE];

            // Open the File
            StreamReader inputFile = File.OpenText("Sales.txt");

            // Read the contents of the file into an array
            while (!inputFile.EndOfStream && index < salesAmount.Length)
            {
                salesAmount[index] = decimal.Parse(inputFile.ReadLine());
                index++;
            }

            // Display the array in the lstSales listbox
            foreach (decimal val in salesAmount)
            {
                lstSales.Items.Add(val.ToString("c"));
            }

            // Calculate the total of sale
            foreach (decimal  val in salesAmount)
            {
                totalSales += val;
            }

            // Display the total
            lblTotal.Text = totalSales.ToString("c");
        }
    }
}
