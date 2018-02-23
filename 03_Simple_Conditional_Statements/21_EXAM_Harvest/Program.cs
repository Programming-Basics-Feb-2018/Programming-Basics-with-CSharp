using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EXAM_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapesPerSqMeter = double.Parse(Console.ReadLine());
            int neededWineLitres = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrapes = vineyardArea * grapesPerSqMeter;
            double totalWine = (totalGrapes * 0.4) / 2.5;

            if (totalWine >= neededWineLitres)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(totalWine - neededWineLitres),
                    Math.Ceiling((totalWine - neededWineLitres) / workersCount));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(neededWineLitres - totalWine));
            }
        }
    }
}
