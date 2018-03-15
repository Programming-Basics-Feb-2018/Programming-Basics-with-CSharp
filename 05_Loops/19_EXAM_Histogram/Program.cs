using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EXAM_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number >= 200 && number < 400)
                {
                    p2 += 1;
                }
                else if (number >= 400 && number < 600)
                {
                    p3 += 1;
                }
                else if (number >= 600 && number < 800)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }

            Console.WriteLine($"{((double)p1 / n * 100.0):F2}%");
            Console.WriteLine($"{((double)p2 / n * 100.0):F2}%");
            Console.WriteLine($"{((double)p3 / n * 100.0):F2}%");
            Console.WriteLine($"{((double)p4 / n * 100.0):F2}%");
            Console.WriteLine($"{((double)p5 / n * 100.0):F2}%");
        }
    }
}
