using System;

namespace _05_Sequence_2k_Plus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int currentNumber = 1;
            while (currentNumber <= n)
            {
                Console.WriteLine(currentNumber);
                currentNumber = 2 * currentNumber + 1;
            }
        }
    }
}
