using System;

namespace _14_Number_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    int number = row + col - 1;
                    if (number > n)
                    {
                        number = n - (number - n);
                    }

                    if (col > 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
