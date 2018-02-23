using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Number_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // проверяваме дали числото ни е равно на 0
            if (number == 0)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("zero");
            }
            else if (number == 1)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                // ако влезнем тук, останалите "else if"-ове и последния "else" НЕ се проверяват
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                // ако влезнем тук, последния "else" НЕ се проверяват
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
