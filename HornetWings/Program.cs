using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine()); //in meters
            long endurance = long.Parse(Console.ReadLine()); //in flaps

            var distance = (wingFlaps / 1000) * distancePer1000Flaps;          
            var seconds = (wingFlaps / endurance) * 5;

            seconds += wingFlaps / 100;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{seconds} s.");           

        }
    }
}
