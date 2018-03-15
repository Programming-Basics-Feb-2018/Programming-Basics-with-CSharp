using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EXAM_Partition_Without_Residue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1 = p1 + 1;
                }
                if (number % 3 == 0)
                {
                    p2 = p2 + 1;
                }
                if (number % 4 == 0)
                {
                    p3 = p3 + 1;
                }
            }

            double p1Percents = 100.0 * ((double)p1 / n);
            double p2Percents = 100.0 * ((double)p2 / n);
            double p3Percents = 100.0 * ((double)p3 / n);

            Console.WriteLine($"{p1Percents:F2}%");
            Console.WriteLine($"{p2Percents:F2}%");
            Console.WriteLine($"{p3Percents:F2}%");
        }
    }
}
