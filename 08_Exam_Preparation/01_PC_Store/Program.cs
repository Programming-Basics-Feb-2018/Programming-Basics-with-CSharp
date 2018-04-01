using System;

namespace _01_PC_Store
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double cpuPriceInUSD = double.Parse(Console.ReadLine());
            double gpuPriceInUSD = double.Parse(Console.ReadLine());
            double ramPriceInUSD = double.Parse(Console.ReadLine());
            int ramUnits = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceInBGN = cpuPriceInUSD * 1.57;
            double gpuPriceInBGN = gpuPriceInUSD * 1.57;
            double ramPriceInBGN = ramPriceInUSD * 1.57;

            double totalRamPrice = ramPriceInBGN * ramUnits;
            double totalCpuPrice = cpuPriceInBGN * (1.0 - discount);
            //double totalCpuPrice = cpuPriceInBGN - (cpuPriceInBGN * discount);
            double totalGpuPrice = gpuPriceInBGN * (1.0 - discount);

            double totalPrice = totalCpuPrice + totalRamPrice + totalGpuPrice;
            Console.WriteLine($"Money needed - {totalPrice:F2} leva.");
        }
    }
}
