using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Number_Pyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col <= row; col++, number += 1)
                {
                    if (number > n)
                    {
                        break;
                    }
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(number);                    
                }
                Console.WriteLine();

                if (number > n)
                {
                    break;
                }
            }
        }
    }
}
