using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EXAM_Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal garderobeSide = decimal.Parse(Console.ReadLine());

            decimal hallLength = (length * 100m) * (width * 100m);
            decimal garderobeLength = (garderobeSide * 100m) * (garderobeSide * 100m);
            decimal benchLength = hallLength / 10m;
            decimal freeSpace = hallLength - garderobeLength - benchLength;
            decimal playersCount = freeSpace / (40m + 7000m);
            Console.WriteLine(Math.Floor(playersCount));
        }
    }
}
