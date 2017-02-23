using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku, jonka summa lasketaan.");

            int number;
            string msg = string.Empty;
            Console.WriteLine("Syötä numero: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            int sum = 0;
            int negative = number < 0 ? -1 : 1;
            for (int i = 1; i <= number * negative; i++)
            {
                sum += i * negative;
            }
            msg = string.Format("{0}", sum);
            Console.WriteLine("Vastaus: {0}", msg);
            Console.ReadKey();
        }
    }
}
