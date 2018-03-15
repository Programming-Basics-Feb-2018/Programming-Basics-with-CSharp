using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int index = 0; index < n; index += 1)
            {
                int summedNumber = int.Parse(Console.ReadLine());

                // Увеличаваме сумата със стойността на променливата "summedNumber"
                sum = sum + summedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
