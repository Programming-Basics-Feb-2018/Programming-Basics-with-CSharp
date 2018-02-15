using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your inches: ");
            double inches = double.Parse(Console.ReadLine());
            double santimeters = inches * 2.54;
            Console.WriteLine("The centimeters equal to -> " + santimeters);
        }
    }
}
