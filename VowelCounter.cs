using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    //Write a C# program using a User Defined Function (UDF) that takes a string input from the user and counts the number of vowels using a return type with no parameters function
    internal class Program
    {
        int RumaFunc()
        { 
            int vowel = 0;
            string str;
            Console.Write("Enter the String : ");
            str = Console.ReadLine();
            str=str.ToLower();
            int i = 0;
            while (i != str.Length)
            {
                if ((str[i] == 'a') || (str[i] == 'e') || (str[i] == 'i') || (str[i] == 'o') || (str[i] == 'u'))
                    vowel++;
                i++;
            }
            return vowel;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int number = p.RumaFunc();

            Console.WriteLine("There are total " + number + " vowels in the string.");

        }
    }
}
