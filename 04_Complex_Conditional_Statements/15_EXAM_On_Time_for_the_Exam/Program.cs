using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EXAM_On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            // 1:30 = 60 + 30 = 90 минути
            int examTotalMinutes = (hourExam * 60) + minutesExam;
            int arrivalTotalMinutes = (hoursArrival * 60) + minutesArrival;
            bool isOnTime = true;

            if (arrivalTotalMinutes <= examTotalMinutes && arrivalTotalMinutes >= examTotalMinutes - 30)
            {
                Console.WriteLine("On time");
            }
            else if (arrivalTotalMinutes < examTotalMinutes - 30)
            {
                Console.WriteLine("Early");
            }
            else
            {
                Console.WriteLine("Late");
                isOnTime = false;
            }

            // Проверяваме дали имаме повече от 60 или 60 минути
            int timeBeforeExamStart = Math.Abs(examTotalMinutes - arrivalTotalMinutes);

            if (isOnTime)
            {
                if (timeBeforeExamStart >= 60)
                {
                    // Използваме деление на общото сумарно време на 60, заради наличието на 60 минути в един час.
                    // Остатъка ни дава наличните минути
                    Console.WriteLine($"{timeBeforeExamStart / 60}:{timeBeforeExamStart % 60:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{timeBeforeExamStart} minutes before the start");
                }
            }
            else
            {
                if (timeBeforeExamStart >= 60)
                {
                    Console.WriteLine($"{timeBeforeExamStart / 60}:{timeBeforeExamStart % 60:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeBeforeExamStart} minutes after the start");
                }
            }
        }
    }
}
