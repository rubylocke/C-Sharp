using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Project_8_5_Structures
{
    public partial class Form1 : Form
    {
        // book Struct
        struct Books
        {
            // struct fields must be public
            public string title;
            public string author;
            public string subject;
            public int book_isdn;

            // Creating getValues method inside Books struct
            // getValues method has 4 parameters
            public void getValues(string t, string a, string s, int id)
            {
                title = t;
                author = a;
                subject = s;
                book_isdn = id;
            }

            // Creating Display method
            public void display()
            {
                MessageBox.Show("Title: " + title +
                    "\nAuthor: " + author +
                    "\nSubject: " + subject +
                    "\nBook ISDN: " + book_isdn);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Creating an instance Book1 of struct Books
            Books Book1 = new Books();

            // Creating an instance Book2 of struct Books
            Books Book2 = new Books();

            // Creating variables
            string t, a, s;
            int id;

            // Stroing the input of textboxs in the variables
            t = tbTitle.Text;
            a = tbAuthor.Text;
            s = tbSubject.Text;
            int.TryParse(tbISBN.Text, out id);

            // Calling getValue method and passing the input of the
            // textboxes as agruments to etValue method parameter
            Book1.getValues(t, a, s, id);

            // Or you can assing values directly to getValue method parameters
            // Books2 details
            Book2.getValues("How to Program with C#", "Dayoub", 
                "C# Programming",123456789);

            // Calling display method to display values
            Book1.display();

            // Calling display method to display values
            Book2.display();
        }
    }
}
