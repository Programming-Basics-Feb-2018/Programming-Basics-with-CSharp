using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EXAM_Sleeping_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int restDaysPlay = days * 127;
            int workingDaysPlay = (365 - days) * 63;
            int totalDays = restDaysPlay + workingDaysPlay;

            if (totalDays <= 30000)
            {
                int totalAvailableMinutes = 30000 - totalDays;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    totalAvailableMinutes / 60,
                    totalAvailableMinutes % 60);
            }
            else
            {
                int totalAvailableMinutes = totalDays - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",
                    totalAvailableMinutes / 60,
                    totalAvailableMinutes % 60);
            }
        }
    }
}
