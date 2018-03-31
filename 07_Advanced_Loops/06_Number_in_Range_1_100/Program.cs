using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Number_in_Range_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.Write("Еnter a number in the range [1...100]:");
                    number = int.Parse(Console.ReadLine());

                    if (number >= 1 && number <= 100)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
                Console.WriteLine("Invalid number!");
            }

            Console.WriteLine("The number is: " + number);
        }
    }
}
