using System;
namespace Question2
{
    internal class Program
    {
        /*
         Write a C# program to check whether a number is positive or negative using simple if statement.
           Example:
           Input → -5
           Output → Number is Negative 
         */
        static void Main(string[] args)
        {
            float num;
            Console.Write("Enter a number  : ");
            num = float.Parse(Console.ReadLine());

            //Operation
            if (num > 0)
                Console.WriteLine("The number " + num + " is a Positive Number.");
            else if (num < 0)
                Console.WriteLine("The number " + num + " is a Negative number.");
            else
                Console.WriteLine("The number " + num + " is Zero.");

        }
    }
}
