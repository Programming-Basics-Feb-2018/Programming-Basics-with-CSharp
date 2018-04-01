using System;

namespace _03_Retirement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string gender = Console.ReadLine().Trim().ToLower();
            int age = int.Parse(Console.ReadLine());
            int workingYears = int.Parse(Console.ReadLine());

            string result = string.Empty;
            if (gender == "male")
            {
                if (age >= 64)
                {
                    if (workingYears >= 38)
                    {
                        result = $"Ready to retire at {age} and {workingYears} years of experience!";
                    }
                    else
                    {
                        int neededExperience = 38 - workingYears;
                        result = $"Old enough, but haven't worked enough. Work experience left to retirement: {neededExperience}.";
                    }
                }
                else
                {
                    if (workingYears >= 38)
                    {
                        int neededYearsWork = 64 - age;
                        result = $"Worked enough, but not old enough. Years left to retirement: {neededYearsWork}.";
                    }
                    else
                    {
                        int neededYears = 64 - age;
                        int neededExperience = 38 - workingYears;
                        result = $"Too early. Years left to retirement: {neededYears}. Work experience left to retirement: {neededExperience}.";
                    }
                }
            }
            else if (gender == "female")
            {
                if (age >= 61)
                {
                    if (workingYears >= 35)
                    {
                        result = $"Ready to retire at {age} and {workingYears} years of experience!";
                    }
                    else
                    {
                        int neededExperience = 35 - workingYears;
                        result = $"Old enough, but haven't worked enough. Work experience left to retirement: {neededExperience}.";
                    }
                }
                else
                {
                    if (workingYears >= 35)
                    {
                        int neededYearsWork = 61 - age;
                        result = $"Worked enough, but not old enough. Years left to retirement: {neededYearsWork}.";
                    }
                    else
                    {
                        int neededYears = 61 - age;
                        int neededExperience = 35 - workingYears;
                        result = $"Too early. Years left to retirement: {neededYears}. Work experience left to retirement: {neededExperience}.";
                    }
                }
            }
            else
            {
                result = "Invalid input.";
            }
            Console.WriteLine(result);
        }
    }
}
