using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_9_3_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGettersSetters_Click(object sender, EventArgs e)
        {
            // variables
            string name;
            double height;
            double weight;

            name = tbName.Text;
            double.TryParse(tbHeight.Text, out height);
            double.TryParse(tbWeight.Text, out weight);

            // Creating objects of class Person
            // Calling parameterized constructor
            Person p1 = new Person(name, height, weight);

            // Calling the default constructor
            Person p2 = new Person();

            // Calling setters methods in Person class
            // Using Setters to set name, height, and weight fields
            // Using personName property to set/get class field newName
            p2.personName = "Alex Garcia";

            // Using personHeight property to set/get class field newHeight
            p2.personHeight = 6.5;
            // Using personWeight property to set/get class field newWeight
            p2.personWeight = 200;

            // Using getters properties to display class fields
            // These values are passed from the textboxes to the parameterized
            //   constructor to set the class fields
            MessageBox.Show("Name: " + p1.personName +
                "\nHeight: " + p1.personHeight +
                "\nWeight: " + p1.personWeight);

            // These values will set the class fiedls thru the default constructor
            MessageBox.Show("Name: " + p2.personName +
                "\nHeight: " + p2.personHeight +
                "\nWeight: " + p2.personWeight);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = string.Empty;
            tbHeight.Text = string.Empty;
            tbWeight.Text = string.Empty;
        }
    }
}
