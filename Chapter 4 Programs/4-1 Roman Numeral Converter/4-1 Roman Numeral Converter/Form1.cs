using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1_Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        const string ROMAN_ONE   = "I";
        const string ROMAN_TWO   = "II";
        const string ROMAN_THREE = "III";
        const string ROMAN_FOUR  = "IV";
        const string ROMAN_FIVE  = "V";
        const string ROMAN_SIX   = "VI";
        const string ROMAN_SEVEN = "VII";
        const string ROMAN_EIGHT = "VIII";
        const string ROMAN_NINE  = "IX";
        const string ROMAN_TEN   = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the form (exit)
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the Textboxes and the output value
            txtUserEnter.Text = "";
            lblOutputRomanNumeral.Text = "";
        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {
            // Clear output value
            lblOutputRomanNumeral.Text = "";

            try
            {
                int outputNumber = 0;    // to hold the data entered

                // Get what is entered and Determine whether the user 
                //     entered a valid number
                if (int.TryParse(txtUserEnter.Text, out outputNumber))
                {
                    if (outputNumber > 10 || outputNumber < 1)
                    {
                        // Display a message asking for a valid value
                        MessageBox.Show("Please enter a valid number.");
                    }
                    else
                    {
                        switch (outputNumber)
                        {
                            case 1:
                                lblOutputRomanNumeral.Text = ROMAN_ONE;
                                break;
                            case 2:
                                lblOutputRomanNumeral.Text = ROMAN_TWO;
                                break;
                            case 3:
                                lblOutputRomanNumeral.Text = ROMAN_THREE;
                                break;
                            case 4:
                                lblOutputRomanNumeral.Text = ROMAN_FOUR;
                                break;
                            case 5:
                                lblOutputRomanNumeral.Text = ROMAN_FIVE;
                                break;
                            case 6:
                                lblOutputRomanNumeral.Text = ROMAN_SIX;
                                break;
                            case 7:
                                lblOutputRomanNumeral.Text = ROMAN_SEVEN;
                                break;
                            case 8:
                                lblOutputRomanNumeral.Text = ROMAN_EIGHT;
                                break;
                            case 9:
                                lblOutputRomanNumeral.Text = ROMAN_NINE;
                                break;
                            case 10:
                                lblOutputRomanNumeral.Text = ROMAN_TEN;
                                break;
                            default:    
                                MessageBox.Show("Please enter a valid number.  second");
                                break;
                        }
                    }
                }
                else
                {
                    // Display a message asking for a numeric value
                    MessageBox.Show("Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                // Display error
                MessageBox.Show(ex.Message);
            }
        }
    }
}
        