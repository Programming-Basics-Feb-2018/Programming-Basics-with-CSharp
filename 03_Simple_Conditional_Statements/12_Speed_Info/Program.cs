using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            
            // Когато работим с променливи с плаваща запетая е препоръчително да използваме n.0 след края на изписването на цели числа
            // 15 = 15.0
            // 23 = 23.0
            //
            //
            if (speed <= 10.0)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10.0 && speed <= 50.0)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50.0 && speed <= 150.0)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150.0 && speed <= 1000.0)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000.0)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
