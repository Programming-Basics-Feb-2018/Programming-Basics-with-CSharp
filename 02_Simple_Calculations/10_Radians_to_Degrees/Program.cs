using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = Math.Round(radians * 57.29578, 0);
            Console.WriteLine(degrees);
        }
    }
}
