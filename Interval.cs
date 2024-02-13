
//Assignment #2_C#
//Roshan Lamichhane
//C0916262
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a real number: ");
            // Using the  double to support real numbers, including decimals.
            double x = Convert.ToDouble(Console.ReadLine());

            // Checking  if x belongs to I using only comparator operators and logical operators
            // I = [2,3[ U ]0,1] U [-10, -2]
            // This translates to: x >= 2 && x < 3 || x > 0 && x <= 1 || x >= -10 && x <= -2


            if ((x >= 2 && x < 3) || (x > 0 && x <= 1) || (x >= -10 && x <= -2))
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
    }
}
