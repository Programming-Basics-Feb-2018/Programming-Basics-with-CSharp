using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EXAM_Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesNumber = int.Parse(Console.ReadLine());
            int wafflesNumber = int.Parse(Console.ReadLine());
            int pancakesNumber = int.Parse(Console.ReadLine());

            double cakesPrice = (double)cakesNumber * 45.0;
            double wafflesPrice = (double)wafflesNumber * 5.8;
            double pancakesPrice = (double)pancakesNumber * 3.2;
            double allPricePerDay = (cakesPrice + wafflesPrice + pancakesPrice) *
                (double)confectionersCount;
            double allCompanyPrice = allPricePerDay * (double)daysCount;
            double finalPrice = allCompanyPrice - (allCompanyPrice / 8.0);

            Console.WriteLine("{0:0.00}", finalPrice);
        }
    }
}
