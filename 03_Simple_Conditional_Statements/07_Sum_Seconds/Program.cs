using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeA = int.Parse(Console.ReadLine());
            int timeB = int.Parse(Console.ReadLine());
            int timeC = int.Parse(Console.ReadLine());
            int totalTime = timeA + timeB + timeC;

            // получаваме минутите като разделим общия брой на секундите на 60
            int minutes = totalTime / 60;

            // получаваме точните секунди ако разделим общия брой секунди на деление с остатък
            int seconds = totalTime % 60;

            // използваме D2 за да допълним с 0 ако дължината на числото е от един символ /пример: 0, 1, 2, 3, ... , 9/
            Console.WriteLine($"{minutes}:{seconds:D2}");
             
            // Можем да решим задачата и използвайки TimeSpan
            //
            //
            // TimeSpan span = new TimeSpan(0, 0, totalTime);
            // Console.WriteLine("{0:m\\:ss}", span);
        }
    }
}
