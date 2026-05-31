namespace KPZ_Lab2.FactoryMethod
{
    public class MobileApp : SubscriptionCreator
    {
        public override Subscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
