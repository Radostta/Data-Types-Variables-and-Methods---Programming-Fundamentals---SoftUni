using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            decimal coffeePrice = 0m;
            decimal total = 0m;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                long capsulesCount = long.Parse(Console.ReadLine());

                coffeePrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                total += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
