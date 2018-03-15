using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            // Използваме for цикъл
            // Започваме от 1 
            //      -> i = 1
            // Ще повтаряме до 100
            //      -> i <= 100
            //Ще увеличаваме i с една единица
            //      -> i++
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
