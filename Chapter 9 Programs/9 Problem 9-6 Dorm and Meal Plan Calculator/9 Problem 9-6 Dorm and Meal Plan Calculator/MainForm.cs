using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_9_6_Dorm_and_Meal_Plan_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChoices_Click(object sender, EventArgs e)
        {
            // variables to store the values what selected
            int dormCost = 0, mealCost = 0, total=0;
                        
            // Create an instance of TotalCost class
            TotalCost totCost = new TotalCost();

            if (cbAllen.Checked)
            {
                totCost.lblOutDormChoice.Text = "Allen Hall";
                totCost.lblOutDormCost.Text = "$1,500";
                // int.TryParse(totCost.lblOutDormCost.Text, out dormCost);
                dormCost = 1500;
            }
            if (cbPike.Checked)
            {
                totCost.lblOutDormChoice.Text = "Pike Hall";
                totCost.lblOutDormCost.Text = "$1,600";
                // int.TryParse(totCost.lblOutDormCost.Text, out dormCost);
                dormCost = 1600;
            }
            if (cbFarthing.Checked)
            {
                totCost.lblOutDormChoice.Text = "Farthing Hall";
                totCost.lblOutDormCost.Text = "$1,800";
                // int.TryParse(totCost.lblOutDormCost.Text, out dormCost);
                dormCost = 1800;
            }
            if (cbUniversitySuites.Checked)
            {
                totCost.lblOutDormChoice.Text = "University Suites";
                totCost.lblOutDormCost.Text = "$2,500";
                // int.TryParse(totCost.lblOutDormCost.Text, out dormCost);
                dormCost = 2500;
            }

            if (cb7Meals.Checked)
            {
                totCost.lblOutMealPlan.Text = "7 meals per week";
                totCost.lblMealCost.Text = "$600";
                //int.TryParse(totCost.lblMealCost.Text, out mealCost);
                mealCost = 600;
            }
            if (cb14Meals.Checked)
            {
                totCost.lblOutMealPlan.Text = "14 meals per week";
                totCost.lblMealCost.Text = "$1,200";
                // int.TryParse(totCost.lblMealCost.Text, out mealCost);
                mealCost = 1200;
            }
            if (cbUnlimitedMeals.Checked)
            {
                totCost.lblOutMealPlan.Text = "Unlimited Meals";
                totCost.lblMealCost.Text = "$1,700";
                // int.TryParse(totCost.lblMealCost.Text, out mealCost);
                mealCost = 1700;
            }

            total = dormCost + mealCost;
            totCost.lblTotalCost.Text = total.ToString("c0");

            totCost.ShowDialog();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear the Housing RadioButtons
            cbAllen.Checked = false;
            cbPike.Checked = false;
            cbFarthing.Checked = false;
            cbUniversitySuites.Checked = false;

            // Clear the Meals RadioButtons
            cb7Meals.Checked = false;
            cb14Meals.Checked = false;
            cbUnlimitedMeals.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
