using System;

namespace _06_Prime_Pairs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberAStart = int.Parse(Console.ReadLine());
            int numberBStart = int.Parse(Console.ReadLine());
            int summerIsCommingSoonA = int.Parse(Console.ReadLine());
            int summerIsCommingSoonB = int.Parse(Console.ReadLine());

            for (int numA = numberAStart; numA <= numberAStart + summerIsCommingSoonA; numA++)
            {
                for (int numB = numberBStart; numB <= numberBStart + summerIsCommingSoonB; numB++)
                {
                    // А просто ли е  ?
                    bool isNumberAPrime = numA > 1;
                    for (int i = 2; i <= Math.Sqrt(numA); i++)
                    {
                        if (numA % i == 0)
                        {
                            isNumberAPrime = false;
                            break;
                        }
                    }

                    // Б просто ли е ?
                    bool isNumberBPrime = numB > 1;
                    for (int i = 2; i <= Math.Sqrt(numB); i++)
                    {
                        if (numB % i == 0)
                        {
                            isNumberBPrime = false;
                            break;
                        }
                    }

                    if (isNumberAPrime && isNumberBPrime)
                    {
                        Console.WriteLine($"{numA}{numB}");
                    }
                }
            }
        }
    }
}
