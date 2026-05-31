using System.Collections.Generic;

namespace KPZ_Lab2.FactoryMethod
{
    public abstract class Subscription
    {
        public double MonthlyFee { get; set; }
        public int MinimumPeriod { get; set; }
        public List<string> Channels { get; set; }

        public abstract void ShowInfo();
    }
}
