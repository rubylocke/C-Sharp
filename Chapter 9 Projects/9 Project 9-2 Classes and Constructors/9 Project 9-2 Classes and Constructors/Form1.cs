using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Project_9_2_Classes_and_Constructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // Creating an instance of Person class
            // Instance and object can be used interchangeable
            // Default constructor is called when an object of a class is created
            // Default constructor sets the class fields to default values
            Person p1 = new Person();

            // Display fields
            MessageBox.Show("Name: " + p1.getName() +
                "\nHeight: " + p1.getHeight() +
                "\nWeight: " + p1.getWeight());
        }

        private void btnOverload_Click(object sender, EventArgs e)
        {
            // Declare variables
            string name;
            double height;
            double weight;

            // Getting input thru textboxes
            // The inputs are passed as arguments to the constructor
            name = tbName.Text;
            double.TryParse(tbHeight.Text, out height);
            double.TryParse(tbWeight.Text, out weight);

            // Creating an object of class Person
            // Passing name, height, weight parameters to the constructor
            Person p1 = new Person(name, height, weight);

            // Using getters to display fields
            MessageBox.Show("Name: " + p1.getName() +
               "\nHeight: " + p1.getHeight() +
               "\nWeight: " + p1.getWeight());

        }

        private void btnAccessorsMutators_Click(object sender, EventArgs e)
        {
            // Declare variables
            string name;
            double height;
            double weight;

            // Getting input thru textboxes
            // The inputs are passed as arguments to the constructor
            name = tbName.Text;
            double.TryParse(tbHeight.Text, out height);
            double.TryParse(tbWeight.Text, out weight);

            // Creating an object of class Person
            Person p1 = new Person(name, height, weight);
            Person p2 = new Person();

            // Calling setters methods in Person class
            // Using setters to set name, height, and weight fields
            p2.setName("Alex Garcia");
            p2.setHeight(6.5);
            p2.setWeight(200);

            // Using getters to display fields
            MessageBox.Show("Name: " + p1.getName() +
           "\nHeight: " + p1.getHeight() +
           "\nWeight: " + p1.getWeight());

            MessageBox.Show("Name: " + p2.getName() +
           "\nHeight: " + p2.getHeight() +
           "\nWeight: " + p2.getWeight());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            tbName.Text = string.Empty;
            tbHeight.Text = string.Empty;
            tbWeight.Text = string.Empty;
        }
    }
}
