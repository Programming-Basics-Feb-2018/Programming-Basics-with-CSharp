using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Excellent_Result
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
            if (number >= 5.50)
            {
                // Записваме резултата на конзолата
                Console.WriteLine("Excellent!");
            }
        }
    }
}
