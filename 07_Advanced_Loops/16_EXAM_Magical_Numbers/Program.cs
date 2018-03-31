using System;

namespace _16_EXAM_Magical_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int p1 = 1; p1 <= 9; p1++)
            {
                for (int p2 = 1; p2 <= 9; p2++)
                {
                    for (int p3 = 1; p3 <= 9; p3++)
                    {
                        for (int p4 = 1; p4 <= 9; p4++)
                        {
                            for (int p5 = 1; p5 <= 9; p5++)
                            {
                                for (int p6 = 1; p6 <= 9; p6++)
                                {
                                    if (p1 * p2 * p3 * p4 * p5 * p6 == n)
                                    {
                                        if (isFound)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write($"{p1}{p2}{p3}{p4}{p5}{p6}");
                                        isFound = true;
                                    }
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
