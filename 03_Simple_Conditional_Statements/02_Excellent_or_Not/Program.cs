using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            // Четем входящ параметър от тип стринг от конзолата
            string consoleLine = Console.ReadLine();

            // Конвертираме числото в тип double
            double number = double.Parse(consoleLine);

            // Проверяваме дали подаденото число е по-голямо от 5.50
            // АКО
            if (number >= 5.50)
            {
                // Записваме резултата на конзолата
                Console.WriteLine("Excellent!");
            }
            // в противен случай
            // ИНАЧЕ
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
