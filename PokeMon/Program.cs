using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //n
            int distance = int.Parse(Console.ReadLine()); //m reduces the poke power
            int exhaustionFactor = int.Parse(Console.ReadLine()); //y

            //int halfPower = pokePower / 2;
            int halfPower = (pokePower * 50) / 100;

            int pokesCount = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;

                if (pokePower == halfPower && exhaustionFactor > 0)
                {                                        
                    pokePower /= exhaustionFactor;                   
                }                

                pokesCount++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}
