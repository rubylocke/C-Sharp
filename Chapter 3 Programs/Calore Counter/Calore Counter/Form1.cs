using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calore_Counter
{
    public partial class Form1 : Form
    {
        // Constants
        const int BANANA_CALORIES = 115;
        const int ORANGE_CALORIES = 90;
        const int APPLE_CALORIES = 80;
        const int PEAR_CALORIES = 120;

        // holding field
        private int caloriesCounting = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // clear the calories counter
            caloriesCounting = 0;

            // Reset the calories counter in the form
            caloriesCounter.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void bananaPictureBox_Click(object sender, EventArgs e)
        {
            // add banana calories to counter
            caloriesCounting = caloriesCounting + BANANA_CALORIES;

            // Display the calorie counter
            caloriesCounter.Text = caloriesCounting.ToString();
        }

        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            // add orange calories to counter
            caloriesCounting = caloriesCounting + ORANGE_CALORIES;

            // Display the calorie counter
            caloriesCounter.Text = caloriesCounting.ToString();
        }

        private void applePictureBox_Click(object sender, EventArgs e)
        {
            // add apple calories to counter
            caloriesCounting = caloriesCounting + APPLE_CALORIES;

            // Display the calorie counter
            caloriesCounter.Text = caloriesCounting.ToString();
        }

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            // add pear calories to counter
            caloriesCounting = caloriesCounting + PEAR_CALORIES;

            // Display the calorie counter
            caloriesCounter.Text = caloriesCounting.ToString();
        }
    }
}
