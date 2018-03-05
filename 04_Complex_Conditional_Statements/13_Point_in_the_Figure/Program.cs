using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            bool inLowerRectangle = (pointX > 0.0 && pointX < height * 3.0) && 
                (pointY > 0.0 && pointY < height);
            bool inUpperRectangle = (pointX > height) && (pointX < height * 2.0) && 
                (pointY > 0.0) && (pointY < height * 4.0);

            bool outLowerRectangle = pointX < 0.0 || pointX > height * 3.0 ||
                pointY < 0.0;
            bool outUpperRectangle = pointY > height * 4.0 ||
                (pointY > height && (pointX < height || pointX > height * 2.0));

            if (inLowerRectangle || inUpperRectangle)
            {
                Console.WriteLine("inside");
            }
            else if (outLowerRectangle || outUpperRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
