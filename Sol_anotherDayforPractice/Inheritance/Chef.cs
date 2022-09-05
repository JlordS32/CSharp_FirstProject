using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        public static void makeSalad()
        {
            Console.WriteLine("Chef is making a new salad.");
        }

        public static void makeBurger()
        {
            Console.WriteLine("Chef is now making a burger...");
        }

        public virtual void specialDish()
        {
            Console.WriteLine("Chef is now making a special dish");
        }
    }

    class ItalianChef : Chef
    {
        public static void makeSpaghetti()
        {
            Console.WriteLine("Italian chef is now making spaghetti.");
        }

        public override void specialDish()
        {
            Console.WriteLine("Making a special dish");
        }
    }
}
