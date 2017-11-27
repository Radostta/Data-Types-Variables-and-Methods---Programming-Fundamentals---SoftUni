using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int sitesDownCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            //List<string> websites = new List<string>();

            decimal totalLoss = 0.0m;

            for (int i = 0; i < sitesDownCount; i++)
            {
                var websiteData = Console.ReadLine().Split().ToArray();  
                
                string siteName = websiteData[0];
                decimal siteVisits = decimal.Parse(websiteData[1]);
                decimal pricePerVisit = decimal.Parse(websiteData[2]);

                //websites.Add(siteName);

                decimal siteLoss = siteVisits * pricePerVisit;
                totalLoss += siteLoss;

                Console.WriteLine(siteName);
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, sitesDownCount);

            //foreach (var website in websites)
            //{
            //    Console.WriteLine(website);
            //}

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
