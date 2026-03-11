using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        /*Write a C# program to:
               1. Take 5 numbers in an array
               2. Print all numbers using foreach loop
        */
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            Console.WriteLine("Enter 5 elements : ");

            //Taking Input
           
            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(Console.ReadLine());

            // Output Printing
            Console.WriteLine("\nArray elements are :- \n");
            foreach (int arrVar in nums)
                Console.WriteLine(arrVar);
        }
    }
}
