using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // Вземаме минималната стойност на X и Y
            double minX = Math.Min(x1, x2);
            double minY = Math.Min(y1, y2);

            // Вземаме максималната стойност на X и Y
            double maxX = Math.Max(x1, x2);
            double maxY = Math.Max(y1, y2);

            bool isXInRange = x >= minX && x <= maxX;
            bool isYInRange = y >= minY && y <= maxY;

            if (isXInRange && isYInRange)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
