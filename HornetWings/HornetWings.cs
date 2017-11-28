using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            //restTime = 5 seconds. Makes 100 flips per second

            double distance = wingFlaps * (distancePer1000Flaps / 1000);
            double time = wingFlaps / 100;
            double restTime = (wingFlaps / endurance) * 5;

            double totalTime = time + restTime;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");     
        }
    }
}
