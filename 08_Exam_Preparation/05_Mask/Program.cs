using System;

namespace _05_Mask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 2;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}/{1}|  |{1}\\{0}",
                    new string(' ', (width - 6) / 2 - i),
                    new string(' ', i));
            }

            Console.WriteLine(new string('-', width));
            Console.WriteLine("|{0}_{1}_{0}|",
                new string(' ', (n - 2) / 2),
                new string(' ', width - (((n - 2) / 2 + 2) * 2)));
            Console.WriteLine("|{0}@{1}@{0}|",
                new string(' ', (n - 2) / 2),
                new string(' ', width - (((n - 2) / 2 + 2) * 2)));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', width - 2));
            }

            Console.WriteLine("|{0}OO{0}|", new string(' ', (width - 4) / 2));
            Console.WriteLine("|{0}/  \\{0}|", new string(' ', (width - 6) / 2));
            Console.WriteLine("|{0}||||{0}|", new string(' ', (width - 6) / 2));

            for (int i = 1; i <= n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}",
                    new string('\\', i),
                    new string('`', width - (i * 2)),
                    new string('/', i));
            }
        }
    }
}
