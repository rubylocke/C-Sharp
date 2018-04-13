using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Project_10_1_Encapsulation
{
    class Encapsulation
    {
        // Hiding and encapsulating private field _total
        // The process:
        // Encapsultion is implemented whenever private access modifier is used
        // You can access private fields using get/set methods or properties
        private double _total;

        // Total property is used to set and get private field
        public double Total
        {
            get { return _total; }
            //  commenting the set property make the field read-only
            // set { _total = value; }      
         }


        // Constructor with two parameters
        public Encapsulation(double Value1, double Value2)
        {
            // Assign addNumbers method to _total
            _total = addNumbers(Value1, Value2);
        }

        // addNumbers method has two parameters
        private double addNumbers(double num1, double num2)
        {
            //double sum = num1 + num2;
            //return sum:
            return num1 + num2;
        }

    }
}
