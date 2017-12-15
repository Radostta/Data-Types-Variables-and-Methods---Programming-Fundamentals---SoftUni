using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops_MyExam
{
    class Raindrops_MyExam
    {
        static void Main(string[] args)
        {
            int regionsCount = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double sum = 0;
            double result = 0;

            for (int i = 0; i < regionsCount; i++)
            {
                var data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                long raindropsCount = long.Parse(data[0]);
                long squareMeters = long.Parse(data[1]);

                double regionalCoefficient = (double)raindropsCount / squareMeters;
                sum += regionalCoefficient;
            }

            if (density != 0)
            {
                result = sum / density;
            }
            else
            {
                result = sum;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
