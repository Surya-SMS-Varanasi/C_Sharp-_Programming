using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        /*
         Write a C# program to take marks from the user and print grade using if-else ladder.
          Condition example:
            Marks Grade
            90+     A
            70–89   B
            50–69   C
            <50     Fail

         */
        static void Main(string[] args)
        {
            Console.Write("Enter the marks of the student: ");
            int marks = int.Parse(Console.ReadLine());

            //Operation

            if (marks >= 90)
                Console.WriteLine("Grade : A");
            else if(marks >= 70 && marks <= 89)
                Console.WriteLine("Grade : B");
            else if (marks >= 50 && marks <= 69)
                Console.WriteLine("Grade : C");
            else
                Console.WriteLine("Fail.");
        }
    }
}
