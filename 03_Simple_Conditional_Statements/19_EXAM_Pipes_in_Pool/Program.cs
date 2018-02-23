using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_EXAM_Pipes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeDebitPerHour = int.Parse(Console.ReadLine());
            int secondPipeDebitPerHour = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firstPipeLitersTotal = firstPipeDebitPerHour * hours;
            double secondPipeLitersTotal = secondPipeDebitPerHour * hours;
            double sumPipes = firstPipeLitersTotal + secondPipeLitersTotal;

            if (sumPipes <= poolVolume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Floor((sumPipes * 100.0) / poolVolume),
                    Math.Floor((firstPipeLitersTotal * 100.0) / sumPipes),
                    Math.Floor((secondPipeLitersTotal * 100.0) / sumPipes));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.", 
                    hours, 
                    (sumPipes - poolVolume));
            }
        }
    }
}
