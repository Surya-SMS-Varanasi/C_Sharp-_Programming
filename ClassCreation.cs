using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

   Write a C# program to create a class Student with data members StudentId, Name and Course.
       Create below function:
        getStuDetails()
        printStuDetails()
       Create an object of the class and display the student details.

    */
namespace Question1
{
   class Student
    {
        int StudentId;
        string name, course;

        internal void getStuDetails()
        {
            Console.Write("Enter Student Id : ");
            StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Student's Course : ");
            course = Console.ReadLine();
        }
        internal void printStudentDetail()
        {
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Course : " + course);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); // Object creation

            s1.getStuDetails();
            Console.Clear(); // to clear the screen after taking input from the user
            s1.printStudentDetail(); // result display
        }
    }
}
