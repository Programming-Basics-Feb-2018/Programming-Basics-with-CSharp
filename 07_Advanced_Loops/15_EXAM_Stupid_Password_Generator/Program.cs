using System;

namespace _15_EXAM_Stupid_Password_Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int p1 = 1; p1 <= n; p1++)
            {
                for (int p2 = 1; p2 <= n; p2++)
                {
                    for (char p3 = 'a'; p3 <= 97 + l - 1; p3++)
                    {
                        for (char p4 = 'a'; p4 <= 97 + l - 1; p4++)
                        {
                            for (int p5 = 2; p5 <= n; p5++)
                            {
                                if (p5 > p1 && p5 > p2)
                                {
                                    if (isFound)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write($"{p1}{p2}{p3}{p4}{p5}");

                                    isFound = true;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
