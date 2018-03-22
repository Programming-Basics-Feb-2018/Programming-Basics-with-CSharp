using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Чертаем първия ред
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
            
            // Чертаем от втория до пред последния ред
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');

                if (i == (n - 1) / 2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.WriteLine('*');
            }

            // Чертаем последния ред
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
