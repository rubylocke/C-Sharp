using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_3_Poly_and_Inherit
{
    // Doctor IS a Person
    // Doctor class is derived (inherits) from Person
    // Doctor class has access to all feilds and methods of Person class
    class Doctor : Person
    {
        // Override the setOccupation method in the base class
        public override void setOccupation(string a)
        {
            a = "Eye Doctor in Des Moines, IA";
            MessageBox.Show("Override the occupation to: " + a, "Doctor class");
        }
    }
}
