using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
        }
        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
