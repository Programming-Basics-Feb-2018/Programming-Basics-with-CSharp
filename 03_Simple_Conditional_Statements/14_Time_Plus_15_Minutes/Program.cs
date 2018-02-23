using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // Сумираме тоталното текущо време
            int totalTime = (hours * 60) + minutes;

            // Добавяме 15 минути
            totalTime = totalTime + 15;

            // делим на 60 за да получим общия брой часове
            hours = totalTime / 60;
            
            // вземаме деление с остатък от 24 за да получим правилния  вид
            // 24:00 = 0:00
            // 13:00 = 13:00
            //
            //
            hours = hours % 24;

            minutes = totalTime % 60;

            Console.WriteLine($"{hours}:{minutes:D2}");

            // Можем да използваме променлива от тип DateTime
            // DateTime date = new DateTime(1, 1, 1, hours, minutes, 0);
            // date = date.AddMinutes(15);
            // Console.WriteLine(date.ToString("H:mm"));
        }
    }
}
