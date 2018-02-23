using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            // Методът .ToLower() смалява големината на всички символи в дадения низ
            //      "Toncho" = "toncho"
            //      "THIS IS A TEST SENTANCE" = "this is a test sentance"
            //      "We are the 1th CHAMPIONS!" = "we are the 1th champions!"
            //
            //
            if (firstWord.ToLower() == secondWord.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
