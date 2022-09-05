using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter;

            letter = 'A';
            letter++;

            string first = "Hornsby College of TAFE";
            string second = "TAFE";

            int pos = first.IndexOf(second);
            Console.WriteLine(pos);
            Console.WriteLine(letter);
            Console.ReadLine();
            Console.Clear();

            string oldText = "This is some old text";
            string newText = "a lot of";

            oldText = oldText.Replace("some", newText);

            string someText = "option1|option2|option3|option4";

            string[] splitText = someText.Split('|');

            foreach (string texts in splitText)
            {
                Console.WriteLine(texts);
            }

            Console.WriteLine(oldText);
            Console.ReadLine();
            Console.Clear();

            string newContext = string.Join(",", splitText);
            Console.WriteLine(newContext);
            Console.ReadLine();
            Console.Clear();

            splitText = newContext.Split(',');

            foreach (string n in splitText)
            {
                Console.WriteLine(n);
            }
            
            Console.ReadLine();

            decimal value = 23m;



        }
    }
}
             