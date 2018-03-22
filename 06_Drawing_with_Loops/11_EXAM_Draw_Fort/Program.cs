using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EXAM_Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");

            // От максималната широчина на реда вадим:
            //      2 пъти широчината на частта със символите "^", по неже ги имаме отляво и отдясно
            //      вадим още 4, за допълнителните символи "/ \ / \"
            Console.Write(new string('_', (n * 2) - (((n / 2) * 2) + 4)));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");
            for (int i = 0; i < n - 2 - 1; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', (n * 2) - 2));
                Console.WriteLine("|");
            }

            Console.Write("|");
            Console.Write(new string(' ', ((n / 2)) + 1));
            Console.Write(new string('_', (n * 2) - (((n / 2) * 2) + 4)));
            Console.Write(new string(' ', (n / 2) + 1));
            Console.WriteLine("|");
            
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', (n * 2) - (((n / 2) * 2) + 4)));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
