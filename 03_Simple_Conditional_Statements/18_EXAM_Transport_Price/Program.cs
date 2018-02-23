using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EXAM_Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kms = int.Parse(Console.ReadLine());
            string scheduledAt = Console.ReadLine();

            double totalPrice = 0.0;

            // Ще използваме влак
            if (kms >= 100)
            {
                totalPrice = (double)kms * 0.06;
            }
            // Ще използваме автобус
            else if (kms >= 20 && kms < 100)
            {
                totalPrice = (double)kms * 0.09;
            }
            // Ще изполваме такси
            else if (kms < 20)
            {
                if (scheduledAt == "day")
                {
                    totalPrice = 0.7 + ((double)kms * 0.79);
                }
                else if (scheduledAt == "night")
                {
                    totalPrice = 0.7 + ((double)kms * 0.9);
                }
            }
            
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
