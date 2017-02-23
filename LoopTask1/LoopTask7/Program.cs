using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                {
                    Console.WriteLine("{0}\t{1}", i, Math.Sqrt(i));
                }
            }
            Console.Write("\nPaina jotain näppäintä jatkaaksesi.");
            Console.ReadKey();
        }
    }
}