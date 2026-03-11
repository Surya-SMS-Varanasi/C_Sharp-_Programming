using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# program to create a base (parent) class Person with data members Name and Age.
Create a function GetPersonDetails() to take the input of name and age from the user.
Then create a derived (child) class Student that inherits the Person class.
In the Student class, take Course as input and display all the details.
Create an object of Student class and display the information.
 */
namespace Question1
{
    class Person
    {
        protected string name;
        protected int age;
       protected void GetPersonDetails()
        {
            Console.Write("Enter Name of the Person : ");
            name = Console.ReadLine();
            Console.Write("Enter the age of Person : ");
            age=int.Parse(Console.ReadLine());
        }
    }
    class Student: Person
    {
        string course;
        internal void GetStudentDetails()
        {
            GetPersonDetails();
            Console.Write("Enter Course of the Person : ");
            course = Console.ReadLine();
        }
        internal void PrintStudentDetails()
        {
            Console.WriteLine("Name of the student is : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Course : "+ course);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.GetStudentDetails();
            Console.WriteLine("\n");
            s.PrintStudentDetails();
        }
    }
}
