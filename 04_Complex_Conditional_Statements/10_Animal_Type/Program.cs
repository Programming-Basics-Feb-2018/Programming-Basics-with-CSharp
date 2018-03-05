using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine().ToLower();

            if (animalType == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animalType == "crocodile" || animalType == "tortoise" || animalType == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
