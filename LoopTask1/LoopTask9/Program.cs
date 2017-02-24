using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolikonheitto. Ohjelma antaa heitettyjen kruunujen ja klaavojen määrän. \n");

            Random rnd = new Random();
            int n;
            Console.Write("Anna heittojen määrä: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Virheellinen syöte. Anna uusi luku: ");
            }
            int nHeads = 0, nTails = 0;
            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(2) > 0)
                {
                    nHeads++;
                }
                else
                {
                    nTails++;
                }
            }
            Console.WriteLine("Kolikkoa heitettiin {0} kertaa.", n);
            Console.WriteLine("Klaavoja tuli {0} ja kruunuja {1}.", nTails, nHeads);
            Console.ReadKey();
        }
    }
}