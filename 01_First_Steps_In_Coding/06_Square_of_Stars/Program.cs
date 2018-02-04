using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // COMPLETED: print the rectangle
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
