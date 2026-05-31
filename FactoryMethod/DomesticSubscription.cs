using System;
using System.Collections.Generic;

namespace KPZ_Lab2.FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 99;
            MinimumPeriod = 1;
            Channels = new List<string>
            {
                "News",
                "Movies",
                "Sport"
            };
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Domestic Subscription");
            Console.WriteLine($"Fee: {MonthlyFee}");
            Console.WriteLine($"Period: {MinimumPeriod}");
            Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
            Console.WriteLine();
        }
    }
}
