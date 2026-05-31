namespace KPZ_Lab2.AbstractFactory
{
    public class BalaxyFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new Laptop
            {
                Brand = "Balaxy",
                Model = "Galaxy Book"
            };
        }

        public override Netbook CreateNetbook()
        {
            return new Netbook
            {
                Brand = "Balaxy",
                Model = "Galaxy Net"
            };
        }

        public override EBook CreateEBook()
        {
            return new EBook
            {
                Brand = "Balaxy",
                Model = "Galaxy Reader"
            };
        }

        public override Smartphone CreateSmartphone()
        {
            return new Smartphone
            {
                Brand = "Balaxy",
                Model = "Galaxy S24"
            };
        }
    }
}
