using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kertotaulu luvuille 1-9.\n");

            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
            Console.ReadKey();
        }
    }
}