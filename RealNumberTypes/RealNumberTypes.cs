using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealNumberTypes
{
    class RealNumberTypes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 16)
            {
                Console.WriteLine(double.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine(decimal.Parse(Console.ReadLine()));
            }
            
        }
    }
}
