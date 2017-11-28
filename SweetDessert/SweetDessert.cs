using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());

            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int sets = 0;

            while (guests > 0)
            {
                sets++;
                guests -= 6;
            }

            double totalCost = sets * (2 * bananasPrice) + sets * (4 * eggsPrice) + sets * (0.2 * berriesPrice);

            double difference = Math.Abs(cash - totalCost);

            if (totalCost <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}
