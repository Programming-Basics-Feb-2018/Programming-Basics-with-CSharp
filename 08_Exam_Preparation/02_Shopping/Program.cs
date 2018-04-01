using System;

namespace _02_Shopping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int chocoCount = int.Parse(Console.ReadLine());
            double milkQty = double.Parse(Console.ReadLine());

            double chocoPrice = 0.65 * chocoCount;
            double milkPrice = 2.7 * milkQty;
            double mandarins = Math.Floor(chocoCount - (chocoCount * 0.35));

            double mandarinsPrice = 0.20 * mandarins;
            double totalPrice = mandarinsPrice + chocoPrice + milkPrice;

            if (totalPrice <= budget)
            {
                double budgetIsBigger = budget - totalPrice;
                Console.WriteLine($"You got this, {budgetIsBigger:F2} money left!");
            }
            else
            {
                double budgetIsLower = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {budgetIsLower:F2} more!");
            }
        }
    }
}
