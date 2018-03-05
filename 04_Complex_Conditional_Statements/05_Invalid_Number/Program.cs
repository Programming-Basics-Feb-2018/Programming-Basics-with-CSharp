using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                if (number < 100 || number > 200)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
