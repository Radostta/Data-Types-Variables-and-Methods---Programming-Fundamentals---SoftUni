using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoenixesCount; i++)
            {
                long bodyLength = long.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());

                //var yearsToReincarnate = (decimal)(Math.Pow(bodyLength, 2)) * (bodyWidth + (2 * wingLength));
                decimal yearsToReincarnate = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));

                Console.WriteLine(yearsToReincarnate);
            }
        }
    }
}
