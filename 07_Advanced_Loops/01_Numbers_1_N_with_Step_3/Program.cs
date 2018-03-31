using System;

namespace _01_Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Използваме стандартна FOR конструкция със стъпка, която увеличава нашия индекс с 3 единици
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
