using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someName = "cattac";
            string palindrome = "";

            for (int i = someName.Length-1; i >= 0; i--)
            {
                palindrome += someName[i];
            }

            if (palindrome == someName) Console.WriteLine("It's palindrome");
            else Console.WriteLine("Not palindrome");

            Console.ReadLine();
        }
    }
}
