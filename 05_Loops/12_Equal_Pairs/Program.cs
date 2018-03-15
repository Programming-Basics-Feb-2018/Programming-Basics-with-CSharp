using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int previousSum = int.MinValue;
            int largestDiff = int.MinValue;
            bool areEqual = true;
            for (int i = 0; i < n; i++)
            {
                int numberA = int.Parse(Console.ReadLine());
                int numberB = int.Parse(Console.ReadLine());
                currentSum = numberA + numberB;
                if (i > 0 && currentSum != previousSum)
                {
                    areEqual = false;
                    int currentDiff = Math.Abs(currentSum - previousSum);
                    if (currentDiff > largestDiff)
                    {
                        largestDiff = currentDiff;
                    }
                }
                previousSum = currentSum;
            }

            if (areEqual)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={largestDiff}");
            }
        }
    }
}
