using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Използвавме for цикъл
            // Започваме от символа 'а' /97 ASCII Dec/ и ще повтарме цикъла до символа 'z' /122 ASCII Dec/
            for (char currentChar = 'a'; currentChar <= 'z'; currentChar++)
            {
                Console.WriteLine(currentChar);
            }
        }
    }
}
