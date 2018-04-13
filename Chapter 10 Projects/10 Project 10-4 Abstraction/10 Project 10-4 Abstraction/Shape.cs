using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Project_10_4_Abstraction
{
    // Abstract class is a Base class
    // Meant to be inherited from by derived classes
    abstract class Shape
    {
        // Abstract methods are implicitly virtual
        // Abstract methods have no implementation (bodies)
        // Must be overridden by same methods in derived classes
        public abstract double area();
        public abstract double perimeter();
    }
}
