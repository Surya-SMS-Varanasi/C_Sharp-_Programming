using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# program to create a User Defined Function (UDF) named CheckNumber().
Requirements:
 Take a number as input from the user.
 Use the CheckNumber() function to check whether the number is Even or Odd.
 Display the result on the screen.
Hint: string CheckNumbert();
 */
namespace Question1
{
    internal class Program
    {
        string CheckNumber()
        {
            Console.Write("Enter a number : ");
            float num = float.Parse(Console.ReadLine());

            if (num % 2 == 0)
                return "Number is Even.";
            else
                return "Number is Odd.";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string str = p.CheckNumber();
            Console.WriteLine(str);
        }
    }
}
