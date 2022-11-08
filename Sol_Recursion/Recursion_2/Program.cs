using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "nitin";
            var parts = new List<string>();

            FindPalindrome(word.Length, parts, word);
        }

        static void FindPalindrome(int n, List<string> parts, string s)
        {
            if (n == 0) return;

            for (int i = 0; i < s.Length; i++)
            {
                
            }

            FindPalindrome(n, parts, s);
        }

    }
}
