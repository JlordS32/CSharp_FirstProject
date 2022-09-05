using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethodandClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            usefulTools anotherTool = new usefulTools();
            anotherTool.Saybye("Jesus");
            usefulTools.Sayhi("Jaylou");
            Console.ReadLine();
        }
    }
}
