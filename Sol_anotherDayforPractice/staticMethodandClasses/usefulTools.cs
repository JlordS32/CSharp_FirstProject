﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethodandClasses
{
    internal class usefulTools
    {
        public static void Sayhi(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        public void Saybye(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        public string Apple()
        {
            Sayhi("somebody");
            return "dogshit";
        }
    }

}
