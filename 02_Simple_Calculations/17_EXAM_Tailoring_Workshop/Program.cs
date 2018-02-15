using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EXAM_Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double coverArea = (double)count * (length + (2.00 * 0.3)) * (width + (2 * 0.3));
            double carriageArea = (double)count * (length / 2.0) * (length / 2.0);
            double dollarsPrice = (coverArea * 7.0) + (carriageArea * 9);
            double levsPrice = dollarsPrice * 1.85;

            Console.WriteLine("{0:0.00} USD", dollarsPrice);
            Console.WriteLine("{0:0.00} BGN", levsPrice);
        }
    }
}
