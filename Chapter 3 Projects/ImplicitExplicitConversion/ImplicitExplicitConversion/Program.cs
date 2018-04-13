using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* implicit data conversion is done by the compiler automatically
            when convertng a smaller datatype int to a large datatype like float
            no data loss
            */
            int i = 200;
            float f = i;
            Console.WriteLine(f);

            /* Explicit conversion is done by the programmer when converting
            big datatype to a smaller datatype
            method 1 using typecast operator ()
            method 2 using convert class
            method 3 using Parse functin
            */
            float f1 = 45.238f;
            // conversion using typecast operator, method 1
            // converting a float to int, notice the loss of the decimal point
            int x = (int)f1;
            Console.WriteLine(x);

            // using convert class, method 2
            x = Convert.ToInt32(f1);
            Console.WriteLine(x);

            // Using Parse method to convert a string to int,  method 3
            string str = "1000";
            x = int.Parse(str);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
