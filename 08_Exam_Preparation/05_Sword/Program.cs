using System;

namespace _05_Sword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) + 1;

            // Ред номер 1
            int leftRight = n - 1;
            int spaces = 3;
            Console.WriteLine("{0}/^\\{0}", new string('#', leftRight));


            // n / 2 редове
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}.{1}.{0}",
                    new string('#', leftRight - 1),
                    new string(' ', spaces));

                leftRight -= 1;
                spaces += 2;
            }

            // SOFT
            Console.WriteLine("{0}|{1}S{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));
            Console.WriteLine("{0}|{1}O{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));
            Console.WriteLine("{0}|{1}F{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));
            Console.WriteLine("{0}|{1}T{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));


            if (n == 4)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('#', leftRight),
                    new string(' ', (width - ((leftRight + 1) * 2))));
            }
            else
            {
                for (int i = 0; i < n - 4; i++)
                {
                    Console.WriteLine("{0}|{1}|{0}",
                        new string('#', leftRight),
                        new string(' ', (width - ((leftRight + 1) * 2))));
                }
            }

            // UNI
            Console.WriteLine("{0}|{1}U{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));
            Console.WriteLine("{0}|{1}N{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));
            Console.WriteLine("{0}|{1}I{1}|{0}",
                new string('#', leftRight),
                new string(' ', (width - ((leftRight + 1) * 2)) / 2));

            // Draw Hilt
            Console.WriteLine("@{0}@", new string('=', width - 2));
            int handleSword = ((n + 1) / 2) + 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('#', handleSword),
                    new string(' ', width - ((handleSword + 1) * 2)));
            }

            Console.WriteLine("{0}\\{1}/{0}",
                new string('#', handleSword),
                new string('.', width - ((handleSword + 1) * 2)));
        }
    }
}
