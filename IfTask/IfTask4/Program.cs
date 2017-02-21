using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 0;
            string message = string.Empty;
            Console.Write("");
            bool result = int.TryParse(Console.ReadLine(), out number);

            if (!result)
            {
                message = "Not a number";
            }
             */
            int num1 = 0, num2 = 0, num3 = 0;


            Console.WriteLine("This program arrays your input numbers from lowest to highest.");

            Console.WriteLine("input 1st number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input 2nd number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("input 3rd number");
            num3 = int.Parse(Console.ReadLine());


            Console.Clear();



            int lowest = ((num1 < num2 ? num1 : num2) < num3 ?
                (num1 < num2 ? num1 : num2) : num3);

            int middle = ((num1 < num2 ? num1 : num2) > num3 ?
                (num1 < num2 ? num1 : num2) : num3);

            int highest = ((num1 > num2 ? num1 : num2) > num3 ?
                (num1 > num2 ? num1 : num2) : num3);

            Console.WriteLine(" Numbers from lowest to highest");
            Console.WriteLine("{0}", lowest);
            Console.WriteLine("{0}", middle);
            Console.WriteLine("{0}", highest);
            Console.ReadLine();





        }
    }
}
