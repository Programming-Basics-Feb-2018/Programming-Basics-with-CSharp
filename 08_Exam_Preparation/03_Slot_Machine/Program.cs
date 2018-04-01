using System;

namespace _03_Slot_Machine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            int symbolAIntParsed = (int)n + n1;
            int symbolBIntParsed = (int)m + m1;
            int symbolCIntParsed = (int)k + k1;

            char symA = (char)symbolAIntParsed;
            char symB = (char)symbolBIntParsed;
            char symC = (char)symbolCIntParsed;

            string result = "" + symA + symB + symC;

            Console.WriteLine(result);
            if (result == "777")
            {
                Console.WriteLine("*** JACKPOT ***");
            }
            else if (result == "@@@")
            {
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
        }
    }
}
