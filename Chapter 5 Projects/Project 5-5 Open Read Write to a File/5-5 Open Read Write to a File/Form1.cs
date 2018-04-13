using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // need for input and output for external files:  StreamReader & StreamWriter

namespace _5_5_Open_Read_Write_to_a_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenRead_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog calls called ofd
            // class starts open file dialog
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files (*.txt)|*.txt|Images (*.png)|*.png";
            ofd.Title = "Open a File!";

            // Checks if the user selected a file to open and clicked the Open button
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // creating an instance of StreamReader class called sr
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));

                // ReadToEnd method reads the file to the end
                // Load the file contents to the textbox tbOutput
                tbOutput.Text = sr.ReadToEnd();

                // Close the file
                sr.Dispose();
            }
        }

        private void btnWriteSave_Click(object sender, EventArgs e)
        {
            // Creating an instance of SaveFileDialog class called sfd
            SaveFileDialog sfd = new SaveFileDialog();

            // Saves files as text or images only
            sfd.Filter = "Text files (*.txt)|*.txt|Images (*.png)|*.png";
            sfd.Title = "Save Files as Texts or Images!";

            // checks if the user selected a file to save and clicked the Save Button
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Creating an instance of StreamWriter class
                StreamWriter sw = new StreamWriter(File.Create(sfd.FileName));

                // Write the contents of the textbox (tbOutput) to a text document
                sw.Write(tbOutput.Text);

                // Close the file
                sw.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
