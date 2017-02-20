using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee alennuksesi.");

            Console.WriteLine("Kirjoita nimesi:");
            string Name = Console.ReadLine();

            Console.WriteLine("Valitse alennusluokkasi:");
            Console.WriteLine("1: Alle 7-vuotias");
            Console.WriteLine("2: Yli 65-vuotias");
            Console.WriteLine("3: 7-15 vuotias");
            Console.WriteLine("4:Varusmies");
            Console.WriteLine("5:Opiskelija");
            Console.WriteLine("6:MTK-jäsen");
            Console.WriteLine("7:MTK-jäsen ja opiskelija");
            Console.WriteLine("8:Normaalihintainen");

            //int Number = int.Parse(Console.ReadLine());
            int Number = 0;
            bool result = int.TryParse(Console.ReadLine(), out Number);


            if (Number == 1)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 0 euroa", Name);
            }

            else if (Number == 2)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 8 euroa", Name);
            }

            else if (Number == 3)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 8 euroa", Name);
            }

            else if (Number == 4)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 8 euroa", Name);
            }

            else if (Number == 5)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 8,80 euroa", Name);
            }
            else if (Number == 6)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 13,60 euroa", Name);
            }
            else if (Number == 7)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 6,40 euroa", Name);
            }
            else if (Number == 8)
            {
                Console.WriteLine("Nimesi on {0} ja lipun hintasi on: 16 euroa", Name);
            }
            else
            {
                Console.WriteLine("Et valinnut oikein alennusta.");
                Console.WriteLine("Kokeile uudestaan.");
            }

            Console.ReadKey();
        }
    }
}
