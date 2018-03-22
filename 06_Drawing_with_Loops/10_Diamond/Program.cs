using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = -1;

            if (n % 2 == 0)
            {
                mid = 0;
            }

            for (int i = 0; i < (n + 1) / 2; i++, mid += 2)
            {
                int left = (n - 2 - mid) / 2;

                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', left));
                Console.WriteLine();
            }

            mid -= 4;
            for (int i = 0; i < (n + 1) / 2 - 1; i++, mid -= 2)
            {
                int left = (n - 2 - mid) / 2;

                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', left));
                Console.WriteLine();
            }
        }
    }
}
