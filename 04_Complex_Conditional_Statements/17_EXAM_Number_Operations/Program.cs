using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EXAM_Number_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operatorValue = Console.ReadLine();

            if (operatorValue == "+")
            {
                double result = n1 + n2;
                string isEven = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} + {n2} = {result} - {isEven}");
            }
            else if (operatorValue == "-")
            {
                double result = n1 - n2;
                string isEven = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} - {n2} = {result} - {isEven}");
            }
            else if (operatorValue == "*")
            {
                double result = n1 * n2;
                string isEven = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} * {n2} = {result} - {isEven}");
            }
            else if (operatorValue == "/")
            {
                if (n2 == 0.0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
            }
            else if (operatorValue == "%")
            {
                if (n2 == 0.0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }
        }
    }
}
