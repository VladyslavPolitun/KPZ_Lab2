using System;
using System.Collections.Generic;

namespace KPZ_Lab2.FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 49;
            MinimumPeriod = 3;
            Channels = new List<string>
            {
                "Discovery",
                "National Geographic",
                "Science"
            };
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Educational Subscription");
            Console.WriteLine($"Fee: {MonthlyFee}");
            Console.WriteLine($"Period: {MinimumPeriod}");
            Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
            Console.WriteLine();
        }
    }
}
