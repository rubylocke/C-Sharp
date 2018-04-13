using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_3_Poly_and_Inherit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            // internal variables declaration
            string fn, ln, oc;

            // get info from textboxes
            fn = tbFirstName.Text;
            ln = tbLastName.Text;
            oc = tbOccupation.Text;

            // Passing parameters to the constructor in base class Person
            // Instantiating Person class
            Person p = new Person(fn, ln, oc);

            // Display info
            p.displayInfo();

            // Doctor d = new Doctor();
            // d.setOccupation(oc);

            // Polymorphism allos you to invlke derived class method thru
            //  base class reference during runtime
            // This means an object can exist in many forms
            // This is how polymorphism at work!
            Person p1 = new Doctor();

            // This method exits in both classes but hte method in the derived
            //   overrides the method in the base class
            p1.setOccupation(oc);
            
            // Display the info                     Do not understanding
            // MessageBox.Show("p1:");              why displayInfo()
            // p1.displayInfo();                    does not work.  Only show blank

            // Implementing Polymorphism
            Person p2 = new Teacher();
            p2.setOccupation(oc);
            
            // Display the info
            // MessageBox.Show("p2:");
            // p2.displayInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the textboxes
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbOccupation.Text = "";
        }
    }
}
