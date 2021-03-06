﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoopTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee luvun parittomien ja parillisten lukujen summan.");

            int number;
            string msg = string.Empty;
            Console.WriteLine("Syötä luku: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Virheellinen syöte");
            }
            if (number < 0)
            {
                Console.WriteLine("Luku on negatiivinen.");
            }
            int sumOdd = 0, sumEven = 0;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += i;
                    }
                    else
                    {
                        sumOdd += i;
                    }
                }
                msg = string.Format("Parittomien summa: {0}, Parillisten summa: {1}", sumOdd, sumEven);
            }
            
            Console.WriteLine("{0}", msg);
            Console.ReadKey();
        }
    }
}