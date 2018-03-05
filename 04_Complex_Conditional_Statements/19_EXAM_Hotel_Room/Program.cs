using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EXAM_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());
            double apartmentTotalPrice = 0.0;
            double studioTotalPrice = 0.0;

            if (month == "may" || month == "october")
            {
                apartmentTotalPrice = nightsCount * 65.0;
                studioTotalPrice = nightsCount * 50.0;
                if (7 < nightsCount && nightsCount <= 14)
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * (5.0 / 100.0));
                }
                else if (14 < nightsCount)
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * (30.0 / 100.0));
                }
            }
            else if (month == "june" || month == "september")
            {
                apartmentTotalPrice = nightsCount * 68.70;
                studioTotalPrice = nightsCount * 75.20;
                if (14 < nightsCount)
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * (20.0 / 100.0));
                }
            }
            else if (month == "july" || month == "august")
            {
                apartmentTotalPrice = nightsCount * 77.00;
                studioTotalPrice = nightsCount * 76.00;
            }

            if (14 < nightsCount)
            {
                apartmentTotalPrice = apartmentTotalPrice - (apartmentTotalPrice * (10.0 / 100.0));
            }

            Console.WriteLine($"Apartment: {apartmentTotalPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
        }
    }
}
