using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double placePrice = 0.0;
            if (type == "premiere")
            {
                placePrice = 12.00;
            }
            else if (type == "normal")
            {
                placePrice = 7.50;
            }
            else if (type == "discount")
            {
                placePrice = 5.00;
            }

            double totalPrice = (rows * columns) * placePrice;
            Console.WriteLine("{0:F2} leva", totalPrice);
        }
    }
}
