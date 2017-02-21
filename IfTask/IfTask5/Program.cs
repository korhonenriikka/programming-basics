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
            float TicketPrice = 16.0F;
            float Discount = 0.0F;
            bool result = int.TryParse(Console.ReadLine(), out Number);


            if (Number == 1)
            {
                Discount = 1.0F;
            }

            else if (Number == 2)
            {
                Discount = 0.5F;
            }

            else if (Number == 3)
            {
                Discount = 0.5F;
            }

            else if (Number == 4)
            {
                Discount = 0.5F;
            }

            else if (Number == 5)
            {
                Discount = 0.45F;
            }
            else if (Number == 6)
            {
                Discount = 0.15F;
            }
            else if (Number == 7)
            {
                Discount = 0.6F;
            }
            else if (Number == 8)
            {
                Discount = 0.0F;
            }
            else
            {

                Console.WriteLine("Et valinnut oikein alennusta.");
                Console.WriteLine("Kokeile uudestaan.");
            }
            Console.WriteLine("Nimesi on {0} ja lipun hintasi on: {1} euroa", Name, TicketPrice * (1 - Discount));
            Console.ReadKey();
        }
    }
}
