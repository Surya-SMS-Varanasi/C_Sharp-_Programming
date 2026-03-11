using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# program to create a base (parent) class Student with data members RollNo and Name. Create a function GetStudent() to take student details from the user.
Then create a derived (child) class Marks that inherits the Student class. In the Marks class, take marks of two subjects and display the total marks.
Create an object of the Marks class and display student details with total marks.
Hint: use concept of inheritance
 */
namespace Question3
{
    class Student
    {
        protected int RollNo;
        protected string Name;

        protected void GetStudent()
        {
            Console.Write("Enter the Student Id : ");
            RollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the Student Name : ");
            Name = Console.ReadLine();
        }
    }
    class Marks : Student
    {
        int subOneMarks, subTwoMarks, totalMarks;
        internal void GetMarks()
        {
            GetStudent();
            Console.Write("Enter marks in 1st subject : ");
            subOneMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter marks in 2nd subject : ");
            subTwoMarks = int.Parse(Console.ReadLine());
        }
        internal void PrintMarks()
        {
            totalMarks = subOneMarks + subTwoMarks;
            Console.WriteLine("Student Id : " + RollNo);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Total marks : " + totalMarks);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Marks m = new Marks();
            m.GetMarks();
            Console.WriteLine("\n-------------------------------------------------\n");
            m.PrintMarks();
        }
    }
}
