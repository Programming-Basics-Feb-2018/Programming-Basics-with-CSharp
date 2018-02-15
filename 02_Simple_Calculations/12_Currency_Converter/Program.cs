using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();

            if (convertFrom == "BGN")
            {
                if (convertTo == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value / 1.79549, 2), convertTo);
                }
                else if (convertTo == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value / 1.95583, 2), convertTo);
                }
                else if (convertTo == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value / 2.53405, 2), convertTo);
                }
            }
            else if (convertFrom == "USD")
            {
                if (convertTo == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value * 1.79549, 2), convertTo);
                }
                else if (convertTo == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 1.79549) / 1.95583, 2), convertTo);
                }
                else if (convertTo == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 1.79549) / 2.53405, 2), convertTo);
                }
            }
            else if (convertFrom == "EUR")
            {
                if (convertTo == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value * 1.95583, 2), convertTo);
                }
                else if (convertTo == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 1.95583) / 1.79549, 2), convertTo);
                }
                else if (convertTo == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 1.95583) / 2.53405, 2), convertTo);
                }
            }
            else if (convertFrom == "GBP")
            {
                if (convertTo == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(value * 2.53405, 2), convertTo);
                }
                else if (convertTo == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 2.53405) / 1.79549, 2), convertTo);
                }
                else if (convertTo == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round((value * 2.53405) / 1.95583, 2), convertTo);
                }
            }
        }
    }
}
