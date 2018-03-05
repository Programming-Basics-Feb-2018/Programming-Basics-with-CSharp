using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine().ToLower();

            // Проверяваме стойността на променливата "item"
            switch (item)
            {
                // В случай в който тя е равна на тези стойности...
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                case "banana":
                    // Принтираме на конзолата "fruit"
                    Console.WriteLine("fruit");
                    // Спираме изпълнението на switch case блока
                    break;
                case "tomato":
                case "pepper":
                case "carrot":
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                // НЕЗАДЪЛЖИТЕЛЕН блок, който се изпълнява в случай, че не е намерен подходящ case случай
                // работи като "else" условие
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
