using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double maxX = Math.Max(x1, x2);
            double minX = Math.Min(x1, x2);
            double maxY = Math.Max(y1, y2);
            double minY = Math.Min(y1, y2);

            double area = (maxX - minX) * (maxY - minY);
            double perimeter = 2 * ((maxX - minX) + (maxY - minY));

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
