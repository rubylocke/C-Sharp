using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Project_10_4_Abstraction
{
    // Rectangle class inherits Shape class members
    // Rectangle class must implement all abstract methods
    //   of the base abstract class
    class Rectangle : Shape
    {
        // Class fields
        private double _length;
        private double _width;

        // Constructor
        public Rectangle(double a, double b)
        {
            _length = a;
            _width = b;
        }

        // Override abstract method area in abstract class Shape
        public override double area()
        {
            return (_width * _length);
        }
        // Override abstract method perimeter in abstract class Shape
        public override double perimeter()
        {
            return (_width * _length) * 2;
        }
    }
}
