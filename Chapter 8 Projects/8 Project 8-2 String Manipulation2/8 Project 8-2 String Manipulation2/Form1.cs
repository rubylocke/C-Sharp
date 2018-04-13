using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_2_String_Manipulation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            /*
            The Original string is Hello class!
            Character H has an index 0
            White spaces count in strings
            The white space index in Hello class! is 5
            */
            string str = "Hello class";
            MessageBox.Show(str, "Before");

            // Insert the word DMACC at index 5
            // Notice I purposing added leading and trailing white space to DMACC
            MessageBox.Show(str.Insert(5, " DMACC "), "After, with white spaces");

            // Without white spaces
            MessageBox.Show(str.Insert(5, "DMACC"), "After, without white spaces");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // The original string
            string str = "Hello class!!!!";
            MessageBox.Show(str, "Before");

            // Remove all characters starting at index 11
            MessageBox.Show(str.Remove(11), "After");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // The original string
            string str = "Hello class!";
            MessageBox.Show(str, "Before");

            // Replace lower case l with upper case l, All occurrences
            MessageBox.Show(str.Replace("l","L"), "After");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // The original string elements are separated by a delimiter
            //   ; is a delimiater to tell the split function where to stop/start
            string names = "Ali;Tim;Ben;Sarah;Debra;Mike;John";
            MessageBox.Show(names, "Before");

            // Split method splits names array, elements produced are stored in namesArr[]
            string[] namesArr = names.Split(';');

            // loop thru namesArr
            foreach (string newName in namesArr)
            {
                // display the elements of namesArr
                MessageBox.Show(newName, "After");
            }

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // The original string
            string name = "Ruby Locke";

            // Start at index 0, stop at the first white space
            string firstname = name.Substring(0, name.IndexOf(' '));

            //Start at the first white space, display everything afterwards
            string lastname = name.Substring(name.IndexOf(' '));

            // Display the substrings
            MessageBox.Show(firstname);
            MessageBox.Show(lastname);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            // Original string
            string name = "              Ruby Locke       ";
            MessageBox.Show(name, "Without Trim");

            // Trim method removes leading and trailing white spaces
            string myName = name.Trim();
            MessageBox.Show(myName, "With Trim");
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            /*
                Value              Meaning
            Less than zero     When first string is less than second
                Zero           When both strings are equal
            Greater than zero  When first string is greater than second
            */

            string str1 = "abc";
            string str2 = "xyz";

            /*
            if str1 = str2, result = 0
            if str1 > str2, result = 1
            if str1 < str2, result = -1
            when comparing strings the hexadecimal value of the 
            character is compared and considered
            */
            int result = String.Compare(str1, str2);

            // Display result
            MessageBox.Show(result.ToString());

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            // define the strings
            string str1 = "Locke";
            string str2 = "Ruby";

            // Using the Join method to join strings
            // Notice the string comma separator in read
            string name = string.Join(", ", str1, str2);
            MessageBox.Show(name);
        }

        private void btnIgnoreCase_Click(object sender, EventArgs e)
        {
            // Original strings
            string firstString = "DMACC";
            string secondString = "dmacc";

            // We use OrdinalIgnoreCase method in StringComprison class to 
            // ignore upper/lower case letters
            // if both strings match and the differece is only the letter case
            // then the statement is true
            if (firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
