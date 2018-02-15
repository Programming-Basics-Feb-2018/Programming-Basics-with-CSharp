using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_EXAM_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double aquariumArea = (length * width * height) * 0.001;
            double liters = aquariumArea * (1.0 - (percentage * 0.01));

            Console.WriteLine("{0:0.000}", liters);
        }
    }
}
