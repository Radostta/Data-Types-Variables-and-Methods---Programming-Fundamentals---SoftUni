using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigPower
{
    class BigPower
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nPower = BigInteger.Pow(n, n);
            Console.WriteLine(nPower);
        }
    }
}
