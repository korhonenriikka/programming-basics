﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heitetään noppaa 1000 kertaa.\n");

            Random rnd = new Random();
            int result, nSixes = 0;
            for (int i = 1; i <= 1000; i++)
            {
                result = rnd.Next(6) + 1;
                if (result == 6)
                {
                    nSixes++;
                }
                Console.WriteLine("{0}. {1}", i, result);
            }
            Console.WriteLine("Kuutonen arvottiin {0} kertaa.", nSixes);
            Console.ReadKey();
        }
    }
}