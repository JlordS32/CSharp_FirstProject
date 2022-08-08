using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day: ");
            int theNumDay = int.Parse(Console.ReadLine());

            while (theNumDay > 6)
            {
                Console.Clear();
                Console.WriteLine(GetDay(theNumDay));
                Console.Write("Enter a day: ");
                theNumDay = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetDay(theNumDay));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            Console.Clear();

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
