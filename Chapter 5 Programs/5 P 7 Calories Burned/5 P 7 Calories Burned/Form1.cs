using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_P_7_Calories_Burned
{
    public partial class Form1 : Form
    {
        const double CALORIES_BURNT_PER_MINUTE = 3.9;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create varaibles to hold time allotment and calories burned
            int time;      // To hold the time allotment
            double calories;  // To hold the calories burnt
            
            // Title of display
            lbCaloriesBurned.Items.Add("Time\tCalories");

            for (time = 10; time <= 25; time+=5)
            {
                calories = time * CALORIES_BURNT_PER_MINUTE;

                // display the output
                lbCaloriesBurned.Items.Add(time + "\t" + calories);
            }
        }
    }
}
