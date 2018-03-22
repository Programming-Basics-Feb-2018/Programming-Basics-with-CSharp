using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 10; rows++)
            {
                for (int cols = 1; cols <= 10; cols++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
