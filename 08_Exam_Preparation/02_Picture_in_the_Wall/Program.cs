using System;

namespace _02_Picture_in_the_Wall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int wholeWidth = int.Parse(Console.ReadLine());
            int wholeLength = int.Parse(Console.ReadLine());
            int picturesSide = int.Parse(Console.ReadLine());
            int picturesCount = int.Parse(Console.ReadLine());

            int wholeArea = wholeWidth * wholeLength;
            int picturesArea = (picturesSide * picturesSide) * picturesCount;
            int difference = Math.Abs(wholeArea - picturesArea);

            if (wholeArea >= picturesArea)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {difference} bigger than pictures area.");
            }
            else
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {difference} bigger than hole area.");
            }
        }
    }
}
