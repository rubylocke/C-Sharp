using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_9_1_Pet_Class
{
    class Pet
    {
        // Fields to represnt Pet Class
        private string _Name;       // The Pet's name
        private string _Type;       // The Type of the Dog of the pet
        private int _Age;           // The Pet's age

        // Constructor
        public Pet()
        {
            _Name = "";
            _Type = "";
            _Age = 0;
        }

        // override Constructor
        public Pet(string n, string t, int a)
        {
            _Name = n;
            _Type = t;
            _Age = a;
        }

        // Name property
        public string Name { get; set; }

        // Type property
        public string Type { get; set; }

        // Age Progerty
        public int Age { get; set; }

        // Display info
        // Remember you have to add "using System.Windows.Form; to use this
        public void DisplayPet()
        {
            MessageBox.Show(" Pet Info " +
                            "\nName: " + _Name +
                            "\nType: " + _Type + " of Dog" +
                            "\nAge is " + _Age + " years old.");
        }

    }
}
