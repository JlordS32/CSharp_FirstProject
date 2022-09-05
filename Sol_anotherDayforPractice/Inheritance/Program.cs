using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chef.makeSalad();
            //ItalianChef.makeSalad();
            //ItalianChef.makeSpaghetti();
            //FilipinoChef.makeAdobo();

            //FilipinoChef filpo = new FilipinoChef();

            //filpo.makeCalderita();


            Chef chef = new Chef();
            ItalianChef italianChef = new ItalianChef();

            chef.specialDish();
            italianChef.specialDish();


            Console.ReadLine();
        }
    }

    class FilipinoChef : Chef
    {
        public static void makeAdobo()
        {
            Console.WriteLine("Filipino Chef is now making Adobo...");
        }

        public void makeCalderita()
        {
            Console.WriteLine("Now making Caldereta..");
        }

        
    }
}
