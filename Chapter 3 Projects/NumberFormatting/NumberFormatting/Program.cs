using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2500;

            // format i as currency and assign it to str variable
            string str = i.ToString("c");
            // prints str variable
            Console.WriteLine(str);
            // format i as currency with 3 decimal places
            str = i.ToString("c3");
            Console.WriteLine(str);
            // prints empty line
            Console.WriteLine();

            // format i as a number and assign it to str variable
            str = i.ToString("n");
            // prints str variable
            Console.WriteLine(str);
            // number with no decimal places
            str = i.ToString("N0");
            Console.WriteLine(str);
            // prints empty line
            Console.WriteLine();

            // format i as a percent and assign it to str variable
            str = i.ToString("p");
            // prints str variable
            Console.WriteLine(str);
            // reads and holds the terminal
            Console.ReadLine();
        }
    }
}
