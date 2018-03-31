using System;

namespace _12_Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;

            while (true)
            {
                if (n < 2)
                {
                    break;
                }
                int sum = f0 + f1;
                f0 = f1;
                f1 = sum;
                n -= 1;
            }
            Console.WriteLine(f1);
        }
    }
}
