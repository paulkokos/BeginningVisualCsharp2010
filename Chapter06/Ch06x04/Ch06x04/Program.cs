﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06x04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} command line were specified",args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
                Console.ReadKey();
            }
        }
    }
}
