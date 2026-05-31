namespace KPZ_Lab2.AbstractFactory
{
    public class IProneFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new Laptop
            {
                Brand = "IProne",
                Model = "MacBook Pro"
            };
        }

        public override Netbook CreateNetbook()
        {
            return new Netbook
            {
                Brand = "IProne",
                Model = "MacBook Air"
            };
        }

        public override EBook CreateEBook()
        {
            return new EBook
            {
                Brand = "IProne",
                Model = "iBook"
            };
        }

        public override Smartphone CreateSmartphone()
        {
            return new Smartphone
            {
                Brand = "IProne",
                Model = "iPhone 15"
            };
        }
    }
}
