using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            while (number != 0)
            {
                try
                {
                    Console.WriteLine("Anna kokonaisluku väliltä 1 - 150, jonka kertoma lasketaan.");
                   
                    Console.Write("Syötä 0 kun haluat lopettaa: ");
                   
                    number = int.Parse(Console.ReadLine());
                    if (number > 150)
                    {
                        Console.WriteLine("Luku on liian suuri kertoman laskemiseen tällä ohjelmalla.\n");
                    continue;
                    }
                    if (number < 0)
                    {
                        Console.WriteLine("Luku on negatiivinen.\n");
                    continue;
                    }
                    double kertoma = 1;
                    int i = 1;
                    while (i <= number)
                    {
                        kertoma = kertoma * i;
                        i++;
                    }
                    if (number != 0)
                        Console.WriteLine("Luvun " + number + " kertoma on " + kertoma);
                }
                catch
                {
                    Console.WriteLine("Virheellinen syöte.");
                }
            }
        }
    }
}