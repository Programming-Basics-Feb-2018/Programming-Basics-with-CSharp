using System;

namespace _02_Illidan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalGroupPeopleCount = int.Parse(Console.ReadLine());
            int powerPerPerson = int.Parse(Console.ReadLine());
            int lifeIldan = int.Parse(Console.ReadLine());

            int totalPlayersPower = totalGroupPeopleCount * powerPerPerson;
            int difference = Math.Abs(lifeIldan - totalPlayersPower);

            if (lifeIldan > totalPlayersPower)
            {
                Console.WriteLine($"You are not prepared! You need {difference} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {difference} points.");
            }
        }
    }
}
