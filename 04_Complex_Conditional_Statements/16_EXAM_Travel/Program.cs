using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_EXAM_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string place = string.Empty;
            string location = string.Empty;
            double budgetPercentage = 0.0;
            if (budget <= 100.0)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    budgetPercentage = 30.0 / 100.0;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    budgetPercentage = 70.0 / 100.0;
                }
            }
            else if (budget > 100.0 && budget <= 1000.0)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    budgetPercentage = 40.0 / 100.0;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    budgetPercentage = 80.0 / 100.0;
                }
            }
            else if (budget > 1000.0)
            {
                location = "Europe";
                place = "Hotel";
                budgetPercentage = 90.0 / 100.0;
            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{place} - {(budget * budgetPercentage):F2}");
        }
    }
}
