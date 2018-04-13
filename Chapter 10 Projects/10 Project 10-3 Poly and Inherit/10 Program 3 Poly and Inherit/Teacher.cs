using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Program_3_Poly_and_Inherit
{
    class Teacher : Person
    {
        public override void setOccupation(string b)
        {
            // if you comment the line below,  the occupation field will not be overridden
            b = "Instructor @ DMACC";
            MessageBox.Show("Override the occupation to: " + b, "Teacher class");
        }
    }
}
