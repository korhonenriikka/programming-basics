using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTask3
{
    class Program
    {
        static int InsertNumber(int a, int b)
        {
            int n;
            bool res = false;
            do
            {
                Console.Write("Anna luku väliltä {0}-{1}: ", a, b);
                res = int.TryParse(Console.ReadLine(), out n);
            } while (!res || n < a || n > b);
            return n;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Syötit luvun {0}", InsertNumber(-2, 10));
            Console.ReadKey();
        }
    }
}