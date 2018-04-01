using System;

namespace _05_Arrow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n + 5;
            int leftRight = ((width - 3) / 2);

            // Първи ред
            Console.WriteLine("{0}^{0}", new string('_', (width - 1) / 2));

            // Втори ред
            Console.WriteLine(@"{0}/|\{0}", new string('_', leftRight));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(@"{0}/{1}|||{1}\{0}",
                    new string('_', leftRight - 1 - i),
                    new string('.', i));
            }

            // Въвеждаме нашите два статични реда
            Console.WriteLine(@"{0}/..|||..\{0}",
                new string('_', (width - 9) / 2));
            Console.WriteLine(@"{0}/.|||.\{0}",
                new string('_', (width - 7) / 2));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}|||{0}",
                    new string('_', leftRight));
            }

            Console.WriteLine("{0}~~~{0}",
                new string('_', leftRight));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(@"{0}//{1}!{1}\\{0}",
                    new string('_', (leftRight + 1) - 2 - i),
                    new string('.', i));
            }
        }
    }
}
