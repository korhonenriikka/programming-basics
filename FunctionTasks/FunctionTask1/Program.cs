using System;

namespace FunctionTask1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Type number: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            string msg = String.Empty;
            if (IsPositiveNumber(number))
            {

                MakeMsg(number, ref msg);

            }
           
            else
            {
                msg = $"Invalid number {number}";
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private static bool IsPositiveNumber(int num)
        {
            return num > 0;
        }
        private static void MakeMsg(int num, ref string msg)
        {

            for (int i = 0; i < num; i++)
            {
                msg = msg + "*";
            }

        }
    }
}
