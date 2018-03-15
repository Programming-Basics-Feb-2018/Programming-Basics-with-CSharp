using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Четем от конзолата и обръщаме всяка една буква в малка .ToLower()
            string line = Console.ReadLine().ToLower();

            int sum = 0;
            // Преминаваме през всяка една буква от думата като използваме нейната дължина 
            //      line.Length
            //      "tes".Length = 3
            //      "softuni".Length = 7
            for (int i = 0; i < line.Length; i++)
            {
                // Вземаме текущата буква и увеличаваме общата сума ако буквата е гласна
                switch (line[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
