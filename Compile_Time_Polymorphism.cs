using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a C# program to demonstrate method overloading by creating a function Area().
Example:
 Area(int side) → for square
 Area(int length, int width) → for rectangle
Display the result by calling both methods.
Hint: Take input from the user.
 */
namespace Question4
{
    internal class Program
    {
        int Area( int side)
        {
            return side * side;
        }
        int Area(int length, int width)
        {
            return length*width;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Enter the side of Square : ");
            int sqr = int.Parse(Console.ReadLine());
            Console.Write("Enter the length and width of Rectangle : ");
            int len= int.Parse(Console.ReadLine());
            int wid = int.Parse(Console.ReadLine());
            int sqrArea = p.Area(sqr);
            int rectArea = p.Area(len, wid);
            Console.WriteLine("Area of Square is : " + sqrArea);
            Console.WriteLine("Area of Rectangle is : " + rectArea);
        }
    }
}
