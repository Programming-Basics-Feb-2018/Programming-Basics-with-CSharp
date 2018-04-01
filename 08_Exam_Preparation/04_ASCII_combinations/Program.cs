using System;

namespace _04_ASCII_combinations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numsSymbols = string.Empty;
            int numsSums = 0;
            string upperCaseSymbols = string.Empty;
            int upperCaseSums = 0;
            string lowerCaseSymbols = string.Empty;
            int lowerCaseSums = 0;
            string otherSymbols = string.Empty;
            int otherSymbolsSums = 0;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (char.IsDigit(symbol))
                {
                    numsSymbols += symbol;
                    numsSums += (int)symbol;
                }
                else if (char.IsUpper(symbol))
                {
                    upperCaseSymbols += symbol;
                    upperCaseSums += (int)symbol;
                }
                else if (char.IsLower(symbol))
                {
                    lowerCaseSymbols += symbol;
                    lowerCaseSums += (int)symbol;
                }
                else
                {
                    otherSymbols += symbol;
                    otherSymbolsSums += (int)symbol;
                }
            }

            int maxSum = Math.Max(numsSums, Math.Max(upperCaseSums, Math.Max(lowerCaseSums, otherSymbolsSums)));
            string maxString = string.Empty;

            if (numsSums == maxSum)
            {
                maxString = numsSymbols;
            }
            else if (upperCaseSums == maxSum)
            {
                maxString = upperCaseSymbols;
            }
            else if (lowerCaseSums == maxSum)
            {
                maxString = lowerCaseSymbols;
            }
            else
            {
                maxString = otherSymbols;
            }

            Console.WriteLine($"Biggest ASCII sum is:{maxSum}");
            Console.WriteLine($"Combination of characters is:{maxString}");
        }
    }
}
