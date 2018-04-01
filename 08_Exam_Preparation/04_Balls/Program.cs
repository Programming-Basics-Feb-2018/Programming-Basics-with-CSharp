using System;

namespace _04_Balls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int redBallsCount = 0;
            int orangeBallsCount = 0;
            int yellowBallsCount = 0;
            int whiteBallsCount = 0;
            int blackBallsCount = 0;
            int otherColorsCount = 0;
            int points = 0;

            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine();

                if (line == "red")
                {
                    redBallsCount += 1;
                    points = points + 5;
                }
                else if (line == "orange")
                {
                    orangeBallsCount += 1;
                    points += 10;
                }
                else if (line == "yellow")
                {
                    yellowBallsCount += 1;
                    points += 15;
                }
                else if (line == "white")
                {
                    whiteBallsCount += 1;
                    points += 20;
                }
                else if (line == "black")
                {
                    blackBallsCount += 1;
                    points /= 2;
                }
                else
                {
                    otherColorsCount += 1;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redBallsCount}");
            Console.WriteLine($"Points from orange balls: {orangeBallsCount}");
            Console.WriteLine($"Points from yellow balls: {yellowBallsCount}");
            Console.WriteLine($"Points from white balls: {whiteBallsCount}");
            Console.WriteLine($"Other colors picked: {otherColorsCount}");
            Console.WriteLine($"Divides from black balls: {blackBallsCount}");
        }
    }
}
