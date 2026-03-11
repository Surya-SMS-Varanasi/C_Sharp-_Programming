using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    internal class Program
    {
        /*
         Write a C# program to calculate the factorial of a number using while loop.
            Example:
            Input → 5
            Output → Factorial = 120
         */
        static void Main(string[] args)
        {
            int num , i = 1, fact = 1;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());

            // Operation
            if (num < 17)
            {
                while (i <= num)
                {
                    fact = fact * i;
                    i++;
                }
                Console.WriteLine("Factorial = " + fact);
            }
            else
                Console.WriteLine("Can't get the factorial due to interanal error.");
        }
    }
}
