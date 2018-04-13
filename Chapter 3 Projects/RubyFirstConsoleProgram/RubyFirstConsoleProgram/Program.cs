using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyFirstConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter your first name
            Console.WriteLine("Enter your first name");
            // reads and stores your first name in string variable fn
            string fn = Console.ReadLine();
            // enter your last name
            Console.WriteLine("Enter your last name");
            // reads and stores your last name in string variable ln
            string ln = Console.ReadLine();
            // prints to the terminal Hello + first name + last name
            Console.WriteLine("Hello, " + fn + ln);
            // prints empty line
            Console.WriteLine();
            // enter your age
            Console.WriteLine("Enter your age: ");
            // reads and stores your age in a string variable str
            string str = Console.ReadLine();
            // convert string str to double and stores that in age variable
            double age = double.Parse(str);
            // prints to the terminal your current age and your age next year
            Console.WriteLine("Your age is: " + age + ", next year you will be: " + ++age);
            // reads and holds the terminal
            Console.ReadLine();


        }
    }
}
