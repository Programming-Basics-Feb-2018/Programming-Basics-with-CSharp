using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EXAM_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                return;
            }

            int width = (((n + 1) * 2) + (2 * n + 1));
            
            Console.Write(new string('.', (n + 1)));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', (n + 1)));
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', ((n - row) + 1)));
                Console.Write("//");
                Console.Write(new string('_', width - (((n - row) + 1) * 2) - 4));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', ((n - row) + 1)));
            }

            Console.Write("//");
            Console.Write(new string('_', (width - (4 + 5)) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (width - (4 + 5)) / 2));
            Console.WriteLine("\\\\");

            for (int row = n; row >= 1; row--)
            {
                Console.Write(new string('.', ((n - row))));
                Console.Write("\\\\");
                Console.Write(new string('_', width - (((n - row)) * 2) - 4));
                Console.Write("//");
                Console.WriteLine(new string('.', ((n - row))));
            }
        }
    }
}
