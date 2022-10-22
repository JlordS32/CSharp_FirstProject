using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.LengthofLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "luffy is still joyboy";

            string[] splitString = s.Split();

            Console.WriteLine("The last word is '{0}' with the length of {1}.", splitString.Last(), splitString.Last().Length);

            Console.ReadLine();
        }
    }
}
