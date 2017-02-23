using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee luvun parittomien ja parillisten lukujen summan.");

            int number;
            string msg = string.Empty;
            Console.WriteLine("Syötä numero: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Virheellinen syöte");
            }
            int sumOdd = 0, sumEven = 0;
            int negative = number < 0 ? -1 : 1;
            for (int i = 1; i <= number * negative; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i * negative;
                }
                else
                {
                    sumOdd += i * negative;
                }
            }
            msg = string.Format("Parittomien summa: {0}, Parillisten summa: {1}", sumOdd, sumEven);
            Console.WriteLine("{0}", msg);
            Console.ReadKey();
        }
    }
}