using System;

namespace _07_Greatest_Common_Divisor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            while (numberB != 0)
            {
                int temp = numberA % numberB;
                numberA = numberB;
                numberB = temp;
            }
            Console.WriteLine(numberA);
        }
    }
}
