using System;

namespace _06_Special_Combinations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxHundreds = int.Parse(Console.ReadLine());
            int maxTens = int.Parse(Console.ReadLine());
            int maxOnes = int.Parse(Console.ReadLine());

            for (int p1 = 2; p1 <= maxHundreds; p1++)
            {
                for (int p2 = 2; p2 <= maxTens; p2++)
                {
                    for (int p3 = 2; p3 <= maxOnes; p3++)
                    {
                        bool isPrime = p2 > 1;
                        for (int i = 2; i <= Math.Sqrt(p2); i++)
                        {
                            if (p2 % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (p1 % 2 == 0 && p3 % 2 == 0 && isPrime)
                        {
                            Console.WriteLine($"{p1} {p2} {p3}");
                        }
                    }
                }
            }
        }
    }
}
