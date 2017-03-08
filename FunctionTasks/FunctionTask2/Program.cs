using System;

namespace FunctionTask2
{
    class Program
    {
        static int Minimi(int a, int b)
        {
            return a < b ? a : b;
        }

        static void Main()
        {
            Console.WriteLine("Tulostaa kahdesta annetusta luvusta pienemmän.\n");

            int a, b;
            Console.Write("Anna luku: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Anna toinen luku: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Minimi: {0}", Minimi(a, b));
            Console.ReadKey();
        }
    }
}