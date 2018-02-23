using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Number_Between_0_and_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            if (number < 0)
            {
                Console.WriteLine("Invalid number");
                // Спираме изпълнението на метода Main
                return;
            }
            else if (number > 100)
            {
                Console.WriteLine("Invalid number");
                // Спираме изпълнението на метода Main
                return;
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
                // Спираме изпълнението на метода Main
                return;
            }
            else if (number == 100)
            {
                Console.WriteLine("One hundred");
                // Спираме изпълнението на метода Main
                return;
            }

            // Създаваме нова променлива от тип стринг и добавяме стойност на празен стринг
            // string result = "";
            //
            //
            string result = string.Empty;

            // Проверяваме дали числото ни НЕ Е между 10 и 19
            if (number / 10 != 1)
            {
                // Проверяваме десетиците
                if (number / 10 == 2)
                {
                    result = "twenty ";
                }
                else if (number / 10 == 3)
                {
                    result = "thirty ";
                }
                else if (number / 10 == 4)
                {
                    result = "forty ";
                }
                else if (number / 10 == 5)
                {
                    result = "fifty ";
                }
                else if (number / 10 == 6)
                {
                    result = "sixty " + result;
                }
                else if (number / 10 == 7)
                {
                    result = "seventy ";
                }
                else if (number / 10 == 8)
                {
                    result = "eighty ";
                }
                else if (number / 10 == 9)
                {
                    result = "ninety ";
                }

                // Проверяваме единиците
                if (number % 10 == 1)
                {
                    result = result + "one";
                }
                else if (number % 10 == 2)
                {
                    result = result + "two";
                }
                else if (number % 10 == 3)
                {
                    result = result + "three";
                }
                else if (number % 10 == 4)
                {
                    result = result + "four";
                }
                else if (number % 10 == 5)
                {
                    result = result + "five";
                }
                else if (number % 10 == 6)
                {
                    result = result + "six";
                }
                else if (number % 10 == 7)
                {
                    result = result + "seven";
                }
                else if (number % 10 == 8)
                {
                    result = result + "eight";
                }
                else if (number % 10 == 9)
                {
                    result = result + "nine";
                }
            }
            else
            {
                if (number % 10 == 0)
                {
                    result = "ten";
                }
                else if (number % 10 == 1)
                {
                    result = "eleven";
                }
                else if (number % 10 == 2)
                {
                    result = "twelve";
                }
                else if (number % 10 == 3)
                {
                    result = "thirteen";
                }
                else if (number % 10 == 4)
                {
                    result = "fourteen";
                }
                else if (number % 10 == 5)
                {
                    result = "fifteen";
                }
                else if (number % 10 == 6)
                {
                    result = "sixteen";
                }
                else if (number % 10 == 7)
                {
                    result = "seventeen";
                }
                else if (number % 10 == 8)
                {
                    result = "eighteen";
                }
                else if (number % 10 == 9)
                {
                    result = "nineteen";
                }
            }
            
            // Метода Trim() изчиства празните места в стринг от ляво и от дясно
            // "  Тест" = "Тест"
            // " 123 " = "123"
            //
            //
            Console.WriteLine(result.Trim());
        }
    }
}
