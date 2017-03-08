using System;

namespace FunctionTask4
{
    class Program
    {
        static void TenNumbers()
        {
            int i, max = 0, maxIndex = 0;
            string numbers = string.Empty;
            Console.WriteLine("Syötä 10 lukua");
            for (i = 0; i < 10; i++)
            {
                int number;
                while (true)
                {
                    Console.Write("{0}. ", i + 1);
                    var res = int.TryParse(Console.ReadLine(), out number);
                    if (res)
                    {
                        if (number > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Virheellinen syöte, syötä positiivinen luku");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen syöte, syötä positiivinen luku");
                    }
                }
                if (number > max)
                {
                    max = number;
                    maxIndex = i + 1;
                }
                
                numbers += $"{number} ";
            }
            Console.WriteLine("Syöttämäsi luvut ovat:");
            Console.WriteLine(numbers);
            Console.WriteLine("Suurin syötetty numero on {0} "+" joka oli " + "{1}.luku", max, maxIndex); 
        }
        static void Main()
        {
            Console.WriteLine("Syötä kymmenen lukua, ohjelma tulostaa luvut sekä ilmoittaa suurimman luvun.\n");

            TenNumbers();
            Console.ReadKey();
        }
    }
}