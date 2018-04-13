using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeMaxMinDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0},Max: {1}, Min: {2}",sizeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine("Size of float: {0},Max: {1}, Min: {2}",sizeof(float), float.MaxValue, float.MinValue);
            Console.WriteLine("Size of double: {0},Max: {1}, Min: {2}",sizeof(double), double.MaxValue, double.MinValue);
            Console.WriteLine("Size of long:  {0},Max: {1}, Min: {2}", sizeof(long), long.MaxValue, long.MinValue);
            Console.WriteLine("Size of boolean: {0}, has no Min or Max values",sizeof(bool));
            Console.WriteLine("Size of string: has no Size, Min or Max values");
            Console.WriteLine("Size of decimal: {0},Max: {1}, Min: {2}", sizeof(decimal), decimal.MaxValue, decimal.MinValue);
            Console.ReadLine();
        }
    }
}
