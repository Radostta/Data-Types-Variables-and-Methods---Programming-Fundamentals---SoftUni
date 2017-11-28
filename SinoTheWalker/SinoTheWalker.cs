using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Globalization;
using System.Linq;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            ////-----Calculating manually using System Numerics:

            var departure = Console.ReadLine().Split(':');
            int hours = int.Parse(departure[0]) * 3600;
            int minutes = int.Parse(departure[1]) * 60;
            int seconds = int.Parse(departure[2]);
            int departureTimeInSeconds = hours + minutes + seconds;

            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger secondsPerStep = int.Parse(Console.ReadLine());

            BigInteger arrivalTimeInSeconds = steps * secondsPerStep + departureTimeInSeconds;

            BigInteger arrivalHours = (arrivalTimeInSeconds / 3600) % 24;
            BigInteger arrivalMins = (arrivalTimeInSeconds / 60) % 60;
            BigInteger arrivalSecs = arrivalTimeInSeconds % 60;

            Console.WriteLine($"Time Arrival: {arrivalHours:d2}:{arrivalMins:d2}:{arrivalSecs:d2}"); //:D2 or :00


            ////Using DateTime class, giving exception if steps' time sum is more than 1 day = 86400 seconds

            ////-----Using ParseExact and Culture Info formatting:

            //DateTime leaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            //double steps = double.Parse(Console.ReadLine()) % 86400;
            //double secondsPerStep = double.Parse(Console.ReadLine()) % 86400;

            //double travelTimeInSeconds = steps * secondsPerStep;

            //DateTime arriving = leaving.AddSeconds(travelTimeInSeconds);

            ////Console.WriteLine("Time Arrival: " + arriving.ToString("HH:mm:ss"));
            //Console.WriteLine($"Time Arrival: {arriving:HH:mm:ss}");


            ////------Using DateTime and TimeSpan, adding double values, then converting to TimeOfDay:

            //DateTime leaving = DateTime.Parse(Console.ReadLine());

            //double steps = double.Parse(Console.ReadLine()) % 86400;
            //double secondsPerStep = double.Parse(Console.ReadLine()) % 86400;

            //double timeInHours = steps * secondsPerStep / 3600;

            //TimeSpan arriving = leaving.AddHours(timeInHours).TimeOfDay;

            //Console.WriteLine($"Time Arrival: {arriving}");


            ////-----Using DateTime and TimeSpan, adding to TimeOfDay:

            //DateTime leaving = DateTime.Parse(Console.ReadLine());

            //int steps = int.Parse(Console.ReadLine()) % 86400;
            //int SecondsPerstep = int.Parse(Console.ReadLine()) % 86400;

            //TimeSpan timeInTravel = TimeSpan.FromSeconds(steps * SecondsPerstep);

            //TimeSpan totalTime = leaving.TimeOfDay.Add(timeInTravel);

            //Console.WriteLine($"Time Arrival: {totalTime.Hours:d2}:{totalTime.Minutes:d2}:{totalTime.Seconds:d2}");



        }
    }
}
