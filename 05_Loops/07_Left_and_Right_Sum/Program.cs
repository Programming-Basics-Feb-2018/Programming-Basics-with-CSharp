using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаваме началната сума
            int n = int.Parse(Console.ReadLine());

            // Създаваме променлива, която ще пресмята "ЛЯВАТА" сума
            int leftSum = 0;
            // Изпълняваме n на брой повторения, където четем число и го прибавяме към лявата сума
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum = leftSum + number;
            }

            // Създаваме променлива, кото пресмята "ДЯСНАТА" сума
            int rightSum = 0;
            // Изпълняваме n на брой повторения, където четем число и го прибавяме към дясната сума
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum = rightSum + number;
            }

            // Сравняваме дали лявата сума е еднаква с дясната
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                // В този случай пресмятаме коя е АБСОЛЮТНАТА разлика между двете суми
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
