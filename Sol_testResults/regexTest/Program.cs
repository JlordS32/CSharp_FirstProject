using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regexTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\D");
            Match match = regex.Match("Number 3434");

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
