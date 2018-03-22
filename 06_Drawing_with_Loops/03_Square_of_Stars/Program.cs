using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= n; cols++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
