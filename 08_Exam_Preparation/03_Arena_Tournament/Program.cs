using System;

namespace _03_Arena_Tournament
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double pointsCount = double.Parse(Console.ReadLine());
            string arenaName = Console.ReadLine();
            string day = Console.ReadLine();
            string toolsState = Console.ReadLine();

            double totalItemsPrice = 0.0;
            switch (toolsState)
            {
                case "Poor":
                    totalItemsPrice = 7000.0;
                    break;
                case "Normal":
                    totalItemsPrice = 14000.0;
                    break;
                case "Legendary":
                    totalItemsPrice = 21000.0;
                    break;
            }
            
            double discount = 0.0;

            if (arenaName == "Nagrand" && (day == "Monday" || day == "Wednesday"))
            {
                discount = 0.05;
            }
            else if (arenaName == "Gurubashi" && (day == "Tuesday" || day == "Thursday"))
            {
                discount = 0.10;
            }
            else if (arenaName == "Dire Maul" && (day == "Friday" || day == "Saturday"))
            {
                discount = 0.07;
            }
            
            double pricePerItem = (totalItemsPrice - (totalItemsPrice * discount)) / 5.0;
            
            int totalCount = 0;
            while (true)
            {
                if (pointsCount - pricePerItem < 0 || totalCount >= 5)
                {
                    break;
                }
                pointsCount -= pricePerItem;
                totalCount += 1;
            }

            Console.WriteLine($"Items bought: {totalCount}");
            Console.WriteLine($"Arena points left: {pointsCount}");

            if (totalCount >= 5)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Failure!");
            }
        }
    }
}
