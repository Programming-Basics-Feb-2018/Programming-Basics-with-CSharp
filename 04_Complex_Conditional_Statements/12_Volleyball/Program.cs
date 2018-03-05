using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string isLeapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            int fullYearWeekends = 48;
            double weekendsInSofia = (fullYearWeekends - weekendsHome) * 3.0 / 4.0;
            double holidaysWeekends = holidays * 2.0 / 3.0;
            double total = weekendsInSofia + weekendsHome + holidaysWeekends;

            if (isLeapYear == "leap")
            {
                total = total + (total * (15.0 / 100.0));
            }
            Console.WriteLine("{0}", Math.Floor(total));
        }
    }
}
