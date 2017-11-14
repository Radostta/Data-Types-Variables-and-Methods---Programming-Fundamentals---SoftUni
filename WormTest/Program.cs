using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wormLength = int.Parse(Console.ReadLine()); //in meters
            double wormWidth = double.Parse(Console.ReadLine()); //in cm

            wormLength *= 100; //in cm
            double result = 0;

            if (wormWidth == 0 || wormLength % wormWidth == 0)
            {
                result = (double)wormLength * wormWidth;
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                result = ((double)wormLength / wormWidth) * 100;
                Console.WriteLine($"{result:f2}%");
            }

           

        }
    }
}
