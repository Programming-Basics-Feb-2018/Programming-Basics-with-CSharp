using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleLine = Console.ReadLine();
            int number = int.Parse(consoleLine);
            bool isEven = number % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
