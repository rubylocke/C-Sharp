using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_7_Image_List
{
    public partial class Form1 : Form
    {
        // Declare a global variable
        // i represents an index of an image in the Images[] array
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // If i is < the images count in the imageList then
            if (i < imageList1.Images.Count)
            {
                // put the image in the Images array and add it to the picture box picBirds:  
                picBirds.Image = imageList1.Images[i];

                // increment i
                i++;

                // Display i on the lblTitle
                lblTitle.Text = "Image: " + i;
            }
            else
            {
                // when i = imageList1.Images.Count, reset i to 0
                // This will make images loop continuously
                i = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Enable the timer
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Disable timer
            timer1.Enabled = false;
        }
    }
}
