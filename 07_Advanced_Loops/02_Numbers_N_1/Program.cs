using System;

namespace _02_Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Започваме нашия цикъл от подаденото n число
            // Проверваме дали текущия индекс ни е по голям или равен на 1
            // Намаляваме шиндекса с 1 единица
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
