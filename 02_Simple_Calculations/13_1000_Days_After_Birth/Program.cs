using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
