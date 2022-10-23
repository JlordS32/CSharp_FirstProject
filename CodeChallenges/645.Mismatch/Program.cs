using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _645.Mismatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 2, 4 };
            int[] repeatedNumber = new int[s.Length];
            int[] correctNumber = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0) continue;
                else if (s[i] == s[i - 1])
                {
                    repeatedNumber[0] = s[i];
                    correctNumber[0] = s[i] + 1;
                }
            }

            Console.WriteLine("[{0}, {1}]", repeatedNumber[0], correctNumber[0]);

            Console.ReadLine();
        }
    }
}
