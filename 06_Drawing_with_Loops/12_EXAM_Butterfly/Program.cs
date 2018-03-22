using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EXAM_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int leftRight = n - 2;

            for (int i = 1; i <= height / 2; i++)
            {
                char wing = '*';
                if (i % 2 == 0)
                {
                    wing = '-';
                }
                Console.Write(new string(wing, leftRight));
                Console.Write("\\ /");
                Console.WriteLine(new string(wing, leftRight));
            }

            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine(new string(' ', n));

            for (int i = 1; i <= height / 2; i++)
            {
                char wing = '*';
                if (i % 2 == 0)
                {
                    wing = '-';
                }
                Console.Write(new string(wing, leftRight));
                Console.Write("/ \\");
                Console.WriteLine(new string(wing, leftRight));
            }
        }
    }
}
