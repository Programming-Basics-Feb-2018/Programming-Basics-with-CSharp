using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Създаваме променлива maxNumber, където ще съхранваме максималната стойност
            int maxNumber = int.MinValue;
            for (int index = 0; index < n; index += 1)
            {
                int number = int.Parse(Console.ReadLine());

                // Проверваме дали текущото число е по-голямо от "maxNumber"
                if (number > maxNumber)
                {
                    // Ако е по-голямо задаваме стойността на текущото число към максималното
                    maxNumber = number;
                }
            }
            if (maxNumber != int.MinValue)
            {
                Console.WriteLine(maxNumber);
            }
        }
    }
}
