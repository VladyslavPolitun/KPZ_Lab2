using System;
using System.Collections.Generic;

namespace KPZ_Lab2.FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 199;
            MinimumPeriod = 12;
            Channels = new List<string>
            {
                "All Channels",
                "4K Content",
                "Exclusive Shows"
            };
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Premium Subscription");
            Console.WriteLine($"Fee: {MonthlyFee}");
            Console.WriteLine($"Period: {MinimumPeriod}");
            Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
            Console.WriteLine();
        }
    }
}
