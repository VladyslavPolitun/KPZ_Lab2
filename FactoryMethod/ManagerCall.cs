namespace KPZ_Lab2.FactoryMethod
{
    public class ManagerCall : SubscriptionCreator
    {
        public override Subscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}
