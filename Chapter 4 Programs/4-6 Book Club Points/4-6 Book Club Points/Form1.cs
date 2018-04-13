using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_6_Book_Club_Points
{
    public partial class Form1 : Form
    {
        // Points via number of books you purchased.
        const int BOOKS_NIL   = 0;
        const int BOOKS_ONE   = 5;
        const int BOOKS_TWO   = 15;
        const int BOOKS_THREE = 30;
        const int BOOKS_MAX   = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePoints_Click(object sender, EventArgs e)
        {
            int books  = 0;  // To hold the number of books customer purchased
            
            // Get the number of books 
            if (int.TryParse(tbBooksPurchase.Text, out books))
            {
                // Calculate points
                if (books == 0)
                {
                    lblCalculatedPoints.Text = BOOKS_NIL.ToString();
                }
                else if (books == 1)
                {
                    lblCalculatedPoints.Text = BOOKS_ONE.ToString();
                }
                else if (books == 2)
                {
                    lblCalculatedPoints.Text = BOOKS_TWO.ToString();
                }
                else if (books == 3)
                {
                    lblCalculatedPoints.Text = BOOKS_THREE.ToString();
                }
                else if (books > 3)
                {
                    lblCalculatedPoints.Text = BOOKS_MAX.ToString(); 
                }
            }
            else
            {
                MessageBox.Show("Numeric Value needed for Books");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes
            tbBooksPurchase.Text = "";

            // Clear the output box
            lblCalculatedPoints.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
