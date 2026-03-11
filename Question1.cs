using System;

namespace Question1
{
    internal class Program
    {
        /*
         Write a C# program to take two numbers from the user and print their sum, subtraction, multiplication, and division.

            Example:
            Input → 10, 5
            Output →
            Sum = 15
            Subtraction = 5
            Multiplication = 50
            Division = 2

         */
        static void Main(string[] args)
        {
            float num1, num2;
            Console.Write("Enter the First Number : ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second Number : ");
            num2 = float.Parse(Console.ReadLine());

            //Operations
            Console.WriteLine("Sum = " + (num1 + num2));
            Console.WriteLine("Substraction = "+ (num1 - num2));
            Console.WriteLine("Multiplication = " + (num1 * num2));
            if (num2 == 0)
                Console.WriteLine("Division = 'Undefined' ");
            else
                Console.WriteLine("Division = " + (num1 / num2));
        }
    }
}
