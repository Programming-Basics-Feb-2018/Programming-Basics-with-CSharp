using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();      // Todor
            string lastName = Console.ReadLine();       // Petkov
            int age = int.Parse(Console.ReadLine());    // 18
            string town = Console.ReadLine();           // Somewhere...
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
