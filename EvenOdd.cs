using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        /*
         Write a C# program to check whether a number is even or odd using if-else.
            Example:
            Input → 7
            Output → Number is Odd
         */
        static void Main(string[] args)
        {
            float num;
            Console.Write("Enter a number : ");
            num = float.Parse(Console.ReadLine());

            //Operation

            if (num % 2 == 0)
                Console.WriteLine("The number " + num + " is an even number.");
            else
                Console.WriteLine("The number " + num + " is an odd number.");

        }
    }
}
