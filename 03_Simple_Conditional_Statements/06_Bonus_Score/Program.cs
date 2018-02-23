using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // Създаваме си променлива, която ще пази броя на бонус точките. 
            // Като за начало нейната стойност ще е равна на 0.0
            double bonusPoints = 0.0;

            // Проверяваме дали числото ни е по-малко или равно на 100, между 100 и 1000 или по-голямо от 1000
            if (number <= 100)
            {
                bonusPoints = 5.0;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusPoints = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusPoints = number * 0.1;
            }

            // Проверяваме дали числото ни е ЧЕТНО
            if (number % 2 == 0)
            {
                bonusPoints += 1.0;
            }

            // Проверяваме дали числото ни завършва на 5, чрез делене с остатък от 10
            // 14 % 10 = 4
            // 127 % 10 = 7
            // 1 % 10 = 1
            // 23 % 10 = 3
            if (number % 10 == 5)
            {
                bonusPoints += 2.0;
            }

            // Принтираме на конзолата нашите бонус точки
            Console.WriteLine(bonusPoints);

            // Принтираме на конзолата нашите бонус точки, събрани с входящото число
            Console.WriteLine(bonusPoints + number);
        }
    }
}
