using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _7_Problem_7_4_Drivers_License_Exam
{
    public partial class Form1 : Form
    {
        // Create an array to hold the correct answers
        const int SIZE = 20;
        string[] correctAnswers = new string[SIZE]
           {"B","D","A","A","C",
            "A","B","A","C","D",
            "B","C","D","A","D",
            "C","C","B","D","A"};


        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            // Create an array to hold items read from the file
            const int SIZE = 20;
            string[] studentAnswers = new string[SIZE];

            try
            {
                // Counter variable to use in the loop
                int index = 0;

                // Declare a StreamReader variable
                StreamReader inputFile;

                // Open this file and get a StreamReader object
                inputFile = File.OpenText("StudentScores.txt");

                // Read the file's contents into an array
                while (index < studentAnswers.Length && !inputFile.EndOfStream)
                {
                    studentAnswers[index] = inputFile.ReadLine();
                    index++;
                }

                //Close the file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }

            int correct = 0;        // To hold the number correct
            int index1 = 0;         // To hold the array subscripts

            // Go through the answers comparing to the correct answers
            while (index1 < correctAnswers.Length)
            {
                if (correctAnswers[index1] == studentAnswers[index1])
                {
                    correct++;
                }
                else
                {
                    lstQuestionsWrong.Items.Add("Question " + (index1 + 1));
                }
                index1++;
            }

            lblCorrect.Text = correct.ToString();

            if (correct > 14)
            {
                lblPassFail.Text = "Passed";
            }
            else
            {
                lblPassFail.Text = "Failed";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCapCorrect_Click(object sender, EventArgs e)
        {

        }

        private void lblCorrect_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCorrect.Text = "";
            lblPassFail.Text = "";
            lstQuestionsWrong.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
