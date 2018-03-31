using System;

namespace _11_Enter_Even_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: " + n);
        }
    }
}
