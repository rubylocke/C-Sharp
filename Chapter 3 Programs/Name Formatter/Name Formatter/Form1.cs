using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void middleNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void formattorButton_Click(object sender, EventArgs e)
        {
            string fullName = "";

            // Concatenate fields into full name
            fullName = titleNameTextBox.Text + " " + firstNameTextBox.Text + " " +
                middleNameTextBox.Text + " " + lastNameTextBox.Text;

            // Display the full name
            fullNameLabel.Text = fullName.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the Text fields
            titleNameTextBox.Text        = "";
            firstNameTextBox.Text        = "";
            middleNameTextBox.Text       = "";
            lastNameTextBox.Text = "";
            fullNameLabel.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
