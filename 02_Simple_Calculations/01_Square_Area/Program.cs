using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, dude, please enter a number -> ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number * number);
        }
    }
}
