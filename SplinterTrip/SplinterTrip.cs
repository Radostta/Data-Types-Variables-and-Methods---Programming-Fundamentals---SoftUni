using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {
            double travelDistance = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWinds = double.Parse(Console.ReadLine());

            double mileInNonHeavyWinds = travelDistance - milesInHeavyWinds;
            double nonHeavyWindsConsumpt = mileInNonHeavyWinds * 25;

            double heavyWindsConsumpt = milesInHeavyWinds * (25 * 1.5);

            double totalFuelConsumpt = nonHeavyWindsConsumpt + heavyWindsConsumpt;
            totalFuelConsumpt += totalFuelConsumpt * 0.05;

            double fuelDifference = Math.Abs(totalFuelConsumpt - fuelTankCapacity);

            Console.WriteLine($"Fuel needed: {totalFuelConsumpt:f2}L");

            if (totalFuelConsumpt <= fuelTankCapacity)
            {
                Console.WriteLine($"Enough with {fuelDifference:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {fuelDifference:f2}L more fuel.");
            }

        }
    }
}
