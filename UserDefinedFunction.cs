using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# program to create a class Rectangle with data members Length and Width. Create a function to calculate the Area of Rectangle and display the result
using an object.
 */
namespace Question2
{
    class Rectangle
    {
       internal float length, width;

        internal void AreaOfRectangle()
        {
            float area = length * width;
            Console.WriteLine("Area of the rectangle is : " +  area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.Write("Enter the Length of the Rectangle : ");
            r.length = float.Parse(Console.ReadLine());
            Console.Write("Enter the Width of the Rectangle : ");
            r.width = float.Parse(Console.ReadLine());

            r.AreaOfRectangle();

            Console.ReadKey();// similar to getch(); in c
        }
    }
}
