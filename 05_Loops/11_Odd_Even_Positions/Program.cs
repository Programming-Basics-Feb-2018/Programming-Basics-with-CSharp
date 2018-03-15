using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_Even_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                // Проверваме дали индекса е четен
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                }
            }

            // Принтираме нечетните суми
            Console.WriteLine($"OddSum={oddSum},");
            if (n >= 1)
            {
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
            }
            else
            {
                Console.WriteLine("OddMin=\"No\",");
                Console.WriteLine("OddMax=\"No\",");
            }

            // Принтираме четните суми
            Console.WriteLine($"EvenSum={evenSum},");
            if (n >= 2)
            {
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else
            {
                Console.WriteLine("EvenMin=\"No\",");
                Console.WriteLine("EvenMax=\"No\"");
            }
        }
    }
}
