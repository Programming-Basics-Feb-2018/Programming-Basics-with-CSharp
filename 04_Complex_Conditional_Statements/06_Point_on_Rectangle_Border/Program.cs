using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Point_on_Rectangle_Border
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

            double minX = Math.Min(x1, x2);
            double maxX = Math.Max(x1, x2);
            double minY = Math.Min(y1, y2);
            double maxY = Math.Max(y1, y2);

            bool isOnLeftSide = x == x1 && (y >= minY && y <= maxY);
            bool isOnRightSide = x == x2 && (y >= minY && y <= maxY);
            bool isOnUpSide = y == y1 && (x >= minX && x <= maxX);
            bool isOnDownSide = y == y2 && (x >= minX && x <= maxX);

            if (isOnLeftSide || isOnRightSide || isOnUpSide || isOnDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
