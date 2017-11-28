using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();            

            while (true)
            {
                var firstPosIndex = input.IndexOf(pattern); //returns either index or - 1
                var lastPosIndex = input.LastIndexOf(pattern);

                bool firstExists = firstPosIndex != -1;
                bool lastExists = lastPosIndex != -1;

                bool firstAndLastIndexesAreEqual = firstPosIndex == lastPosIndex;
                bool patternIsEmpty = pattern == string.Empty;

                if (firstExists && lastExists && !firstAndLastIndexesAreEqual && !patternIsEmpty)
                {
                    input = input.Remove(lastPosIndex, pattern.Length);
                    input = input.Remove(firstPosIndex, pattern.Length);

                    Console.WriteLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length/2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);

                    break;
                }
            }
        }
    }
}
