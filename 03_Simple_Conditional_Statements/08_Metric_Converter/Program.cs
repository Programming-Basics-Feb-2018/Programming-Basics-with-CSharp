using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Използваме променливата decimal за по-голяма точност в изчисленията
            decimal number = decimal.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();

            // Конвертираме от подадената единица в МЕТЪР
            if (convertFrom == "mm")
            {
                // При всяка употреба на променлива от тип decimal на края поставяме символа "m" или "M"
                // за да маркираме стойността на числото да е от същия тип
                number = number / 1000.0m;
                // number = number / 1000.0M;
            }
            else if (convertFrom == "cm")
            {
                number = number / 100.0m;
            }
            else if (convertFrom == "mi")
            {
                number = number / 0.000621371192m;
            }
            else if (convertFrom == "in")
            {
                number = number / 39.3700787m;
            }
            else if (convertFrom == "km")
            {
                number = number / 0.001m;
            }
            else if (convertFrom == "ft")
            {
                number = number / 3.2808399m;
            }
            else if (convertFrom == "yd")
            {
                number = number / 1.0936133m;
            }

            // конвертираме от МЕТЪР в НЕОБХОДИМАТА единица
            if (convertTo == "mm")
            {
                number = number * 1000.0m;
            }
            else if (convertTo == "cm")
            {
                number = number * 100.0m;
            }
            else if (convertTo == "mi")
            {
                number = number * 0.000621371192m;
            }
            else if (convertTo == "in")
            {
                number = number * 39.3700787m;
            }
            else if (convertTo == "km")
            {
                number = number * 0.001m;
            }
            else if (convertTo == "ft")
            {
                number = number * 3.2808399m;
            }
            else if (convertTo == "yd")
            {
                number = number * 1.0936133m;
            }

            // Изполваме :F8 за да запишем числото със закръгляне до 8-мия знак след десетичнта запетая
            Console.WriteLine("{0:F8}", number);
        }
    }
}
