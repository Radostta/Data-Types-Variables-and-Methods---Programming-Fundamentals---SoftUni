using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long avrLapsPerRunner = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long capacityPerDay = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long maximumRunners = capacityPerDay * days;
            runners = runners < maximumRunners ? runners : maximumRunners;

            long totalKm = (runners * avrLapsPerRunner * lapLength) / 1000;
                        
            decimal moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
