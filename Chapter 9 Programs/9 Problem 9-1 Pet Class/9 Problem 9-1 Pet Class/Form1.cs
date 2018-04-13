using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_9_1_Pet_Class
{
    public partial class PetClass : Form
    {
        public PetClass()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            string name, type;       // To hold the pet name and type of dog
            int age;                 // To hold the age of the dog

            name = tbName.Text;
            type = tbTypeOfDog.Text;
            int.TryParse(tbAgeofDog.Text, out age);

            Pet dog = new Pet(name, type, age);
            dog.DisplayPet();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the Text Boxes
            tbName.Text = "";
            tbTypeOfDog.Text = "";
            tbAgeofDog.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
