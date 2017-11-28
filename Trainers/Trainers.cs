using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            int participantsCount = int.Parse(Console.ReadLine());

            var teams = new Dictionary<string, decimal>
            {
                {"Technical Trainers", 0M },
                {"Theoretical Trainers", 0M },
                { "Practical Trainers", 0M }
            };

            for (int i = 0; i < participantsCount; i++)
            {
                int milesToTravel = int.Parse(Console.ReadLine());
                decimal tonsCarried = decimal.Parse(Console.ReadLine());
                string currentTeam = Console.ReadLine();

                long distanceInMeters = milesToTravel * 1600;
                var cargoInKg = tonsCarried * 1000;

                var participantMoneyEarned = (cargoInKg * 1.5M) - (distanceInMeters * 0.7M * 2.5M);

                switch (currentTeam)
                {
                    case "Technical":
                        teams["Technical Trainers"] += participantMoneyEarned;
                        break;
                    case "Practical":
                        teams["Practical Trainers"] += participantMoneyEarned;
                        break;
                    case "Theoretical":
                        teams["Theoretical Trainers"] += participantMoneyEarned;
                        break;
                }
            }

            var winner = teams.OrderByDescending(x => x.Value).FirstOrDefault();
            Console.WriteLine($"The {winner.Key} win with ${winner.Value:F3}.");
        }
    }
}
