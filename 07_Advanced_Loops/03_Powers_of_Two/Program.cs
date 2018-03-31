using System;

namespace _03_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int pow = 0; pow <= n; pow++)
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
