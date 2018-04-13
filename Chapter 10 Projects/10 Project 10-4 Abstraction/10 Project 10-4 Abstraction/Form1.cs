using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Project_10_4_Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // varaible declaration
            double length, width;

            // Storing textboxes input in length and width variables
            // Convert string to double using TryParse method
            double.TryParse(tbLength.Text, out length);
            double.TryParse(tbWidth.Text, out width);

            // Do NOT try this!
            // Shape P = new Shape()

            // Creating object of class rectangle
            // Passing textboxes intpu to the constructor
            Rectangle r = new Rectangle(length, width);

            // Storing the return value of area method in "a" variable
            double recArea = r.area();

            // Display area
            MessageBox.Show("The Rectangle Area is: " + recArea, "Area");

            double recPerimeter = r.perimeter();
            MessageBox.Show("The Rectangle Perimeter is: " + recPerimeter, "Perimeter");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the textboxes
            tbLength.Text = "";
            tbWidth.Text = "";
        }
    }
}
