using System;

namespace _08_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            while (n > 1)
            {
                factorial *= n;
                n -= 1;
            }
            Console.WriteLine(factorial);
        }
    }
}
