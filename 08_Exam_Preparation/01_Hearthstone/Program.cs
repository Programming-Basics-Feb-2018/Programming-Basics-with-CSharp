using System;

namespace _01_Hearthstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            double pricePerDeck = double.Parse(Console.ReadLine());
            double coffePrice = double.Parse(Console.ReadLine());
            double priceOfAdventure = double.Parse(Console.ReadLine());

            int timeForCoffe = 5;
            int timeToBuyDeck = 6;
            int timeToBueAdventure = 4;
            int timeToBreak = time - (timeToBueAdventure + timeToBuyDeck + timeForCoffe);
            double moneyLeft = (3 * pricePerDeck) + (2 * coffePrice) + priceOfAdventure;

            Console.WriteLine($"{moneyLeft:f2}");
            Console.WriteLine(timeToBreak);
        }
    }
}
