namespace KPZ_Lab2.FactoryMethod
{
    public class WebSite : SubscriptionCreator
    {
        public override Subscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
}
