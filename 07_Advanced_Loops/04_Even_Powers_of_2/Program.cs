using System;

namespace _04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int pow = 0; pow <= n; pow += 2)
            {
                int powValue = 1;

                for (int i = 1; i <= pow; i++)
                {
                    powValue *= 2;
                }

                Console.WriteLine(powValue);
            }
        }
    }
}
