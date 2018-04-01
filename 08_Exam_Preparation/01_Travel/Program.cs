using System;

namespace _01_Travel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double truckSpeed = double.Parse(Console.ReadLine());
            double speedDifference = double.Parse(Console.ReadLine());

            double kmPerHDifference = (double)speedDifference * 3.6;
            double carSpeed = kmPerHDifference + truckSpeed;

            double truckTime = distance / truckSpeed;
            double carTime = distance / carSpeed;

            Console.WriteLine($"The truck arrived after {Math.Ceiling(truckTime)} hours");
            Console.WriteLine($"The car arrived after {Math.Ceiling(carTime)} hours");
        }
    }
}
