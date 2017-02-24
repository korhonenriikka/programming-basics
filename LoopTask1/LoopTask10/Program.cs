using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkaus. 1 = kotivoitto, X = tasapeli ja 2 = vierasvoitto \n");

            double res;
            char label;
            Random rnd = new Random();
            for (int i = 1; i <= 13; i++)
            {
                res = rnd.NextDouble();
                if (res < 0.4)
                {
                    label = '1';
                }
                else if (res > 0.6)
                {
                    label = '2';
                }
                else
                {
                    label = 'X';
                }
                Console.WriteLine("{0}. {1}", i, label);
            }
            Console.ReadKey();
        }
    }
}