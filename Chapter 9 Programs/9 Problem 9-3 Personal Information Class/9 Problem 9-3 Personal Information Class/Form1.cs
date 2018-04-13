using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_9_3_Personal_Information_Class
{
    public partial class PersonalInformation : Form
    {
        // List to hold PersonalInfo objects
        List<PersonalInfo> memberList = new List<PersonalInfo>();

        public PersonalInformation()
        {
            InitializeComponent();
        }

        // The GetPersInfo accepts a PersonalInfo object as an argument
        // It assigns teh data entered by the users to the object's properties
        private void GetPersInfo(PersonalInfo person)
        {
            // Temporary variable to hold the age
            int age;

            // Get the PersonalInfo's name
            person.Name = tbName.Text;

            // Get the PersonalInfo's address
            person.Address = tbAddress.Text;

            // Get the PersonalInfo's age
            if (int.TryParse(tbAge.Text, out age))
            {
                person.Age = age;
            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid age. Please re-enter");
            }

            // Get the PersonalInfo's phone
            person.Phone = tbPhone.Text;

        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            // Create a PersonalInfo object
            PersonalInfo member = new PersonalInfo();

            // Get the PersonalInfo data
            GetPersInfo(member);

            // Add the PersonalInfo object to the List
            memberList.Add(member);
            
            // Add an entry to the List Box
            lbPersInfo.Items.Add(member.Name + 
                                 " " + member.Address + 
                                 " " + member.Age + 
                                 " " + member.Phone);

            // Clear the textbox controls
            tbName.Clear();
            tbAddress.Clear();
            tbAge.Clear();
            tbPhone.Clear();

            // Reset the focus
            tbName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbPhone.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void lbPersInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item
            int index = lbPersInfo.SelectedIndex;

            // Display the selected item's info
            MessageBox.Show("Name: " + memberList[index].Name.ToString() +
                "\nAddress: " + memberList[index].Address.ToString() +
                "\nAge: " + memberList[index].Age.ToString() +
                "\nPhone: " + memberList[index].Phone.ToString());
        }
    }
}
