using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Problem_4_Calories_from_Fat_and_Carbs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCarbGrams_Click(object sender, EventArgs e)
        {

        }

        private double FatCalories(double fatgrams)
        {
            return (fatgrams * 9);
        }

        private double CarbCalories(double carbgrams)
        {
            return (carbgrams * 4);
        }

        private void btnCalcFatCalories_Click(object sender, EventArgs e)
        {
            // Variable to hold textbox for fatgram
            double fatgram, fatcalories;

            // Get the fat grams
            if (double.TryParse(tbEnterFat.Text, out fatgram))
            {
                fatcalories = FatCalories(fatgram);
                lblCaloriesFat.Text = fatcalories.ToString();
            }
            else
            {
                // Display error
                MessageBox.Show("Fat grams invalid. Please enter number.");
            }
        }

        private void btnCalcCarbCalories_Click(object sender, EventArgs e)
        {
            // Variable to hold textbox for fatgram
            double carbgram, carbcalories;

            // Get the fat grams
            if (double.TryParse(tbEnterCarb.Text, out carbgram))
            {
                carbcalories = CarbCalories(carbgram);
                lblCaloriesCarb.Text = carbcalories.ToString();
            }
            else
            {
                // Display error
                MessageBox.Show("Carbohydrate grams invalid. Please enter number.");
            }
        }

        private void btnCalcBoth_Click(object sender, EventArgs e)
        {
            // Variable to hold textbox for fatgram
            double fatgram, fatcalories, carbgram, carbcalories;

            // Get the fat grams
            if (double.TryParse(tbEnterFat.Text, out fatgram))
            {
                if(double.TryParse(tbEnterCarb.Text, out carbgram))
                {
                    fatcalories = FatCalories(fatgram);
                    carbcalories = CarbCalories(carbgram);
                    lblCaloriesFat.Text = fatcalories.ToString();
                    lblCaloriesCarb.Text = carbcalories.ToString();
                }
                else
                {
                    MessageBox.Show("Carbohydrate grams invalid. Please enter number.");
                }
            }
            else
            {
                // Display error
                MessageBox.Show("Fat grams invalid. Please enter number.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEnterCarb.Text = "";
            tbEnterFat.Text = "";
            lblCaloriesCarb.Text = "";
            lblCaloriesFat.Text =  "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
