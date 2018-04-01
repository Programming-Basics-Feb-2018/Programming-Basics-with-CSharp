using System;

namespace _04_CSGO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startBudget = int.Parse(Console.ReadLine());

            if (n > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
                return;
            }

            int neededSum = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "ak47":
                        neededSum += 2700;
                        break;
                    case "awp":
                        neededSum += 4750;
                        break;
                    case "sg553":
                        neededSum += 3500;
                        break;
                    case "grenade":
                        neededSum += 300;
                        break;
                    case "flash":
                        neededSum += 250;
                        break;
                    case "glock":
                        neededSum += 500;
                        break;
                    case "bazooka":
                        neededSum += 5600;
                        break;
                }
            }

            if (startBudget >= neededSum)
            {
                Console.WriteLine($"You bought all {n} items! Get to work and defeat the bomb!");
            }
            else
            {
                int neededMoney = neededSum - startBudget;
                Console.WriteLine($"Not enough money! You need {neededMoney} more money.");
            }
        }
    }
}
