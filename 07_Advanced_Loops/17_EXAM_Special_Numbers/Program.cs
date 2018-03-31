using System;

namespace _17_EXAM_Special_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = n < 10 ? n : 9;
            bool isFound = false;

            for (int p1 = 1; p1 <= max; p1++)
            {
                for (int p2 = 1; p2 <= max; p2++)
                {
                    for (int p3 = 1; p3 <= max; p3++)
                    {
                        for (int p4 = 1; p4 <= max; p4++)
                        {
                            if (n % p1 == 0 && n % p2 == 0 && n % p3 == 0 && n % p4 == 0)
                            {
                                if (isFound)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write($"{p1}{p2}{p3}{p4}");
                                isFound = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
