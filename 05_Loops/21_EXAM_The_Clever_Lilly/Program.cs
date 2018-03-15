using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EXAM_The_Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washMasterPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var maxSavedMoney = 0;
            var currentGotten = 0;
            var badBrotherTaken = 0;
            var totalToyPrice = 0;

            for (int currentAge = 1; currentAge <= age; currentAge++)
            {
                // Четните годинки на Лили даваме пари и добавяме по един лев на нейният брат
                if (currentAge % 2 == 0)
                {
                    currentGotten = currentGotten + 10;
                    maxSavedMoney = maxSavedMoney + currentGotten;

                    badBrotherTaken = badBrotherTaken + 1;
                }
                else
                {
                    totalToyPrice = totalToyPrice + toyPrice;
                }
            }

            int maxPrice = maxSavedMoney + totalToyPrice - badBrotherTaken;

            if (washMasterPrice <= maxPrice)
            {
                double difference = (double)maxPrice - washMasterPrice;
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                double difference = washMasterPrice - maxPrice;
                Console.WriteLine($"No! {difference:F2}");
            }
        }
    }
}
