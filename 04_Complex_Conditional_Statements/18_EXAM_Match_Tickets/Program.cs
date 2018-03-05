using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EXAM_Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int count = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            // Проверяваме типа на нашия билет
            if (category == "vip")
            {
                ticketPrice = 499.99;
            }
            else if (category == "normal")
            {
                ticketPrice = 249.99;
            }

            // Проверяваме текущата бройка на хората
            if (count >= 1 && count <= 4)
            {
                budget = budget - (budget * (75.0 / 100.0));
            }
            else if (count >= 5 && count <= 9)
            {
                budget = budget - (budget * (60.0 / 100.0));
            }
            else if (count >= 10 && count <= 24)
            {
                budget = budget - (budget * (50.0 / 100.0));
            }
            else if (count >= 25 && count <= 49)
            {
                budget = budget - (budget * (40.0 / 100.0));
            }
            else if (count >= 50)
            {
                budget = budget - (budget * (25.0 / 100.0));
            }

            double totalPrice = ticketPrice * count;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
            }
        }
    }
}
