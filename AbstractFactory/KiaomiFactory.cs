namespace KPZ_Lab2.AbstractFactory
{
    public class XiaomiFactory : DeviceFactory
    {
        public override Laptop CreateLaptop()
        {
            return new Laptop
            {
                Brand = "Xiaomi",
                Model = "Mi Laptop"
            };
        }

        public override Netbook CreateNetbook()
        {
            return new Netbook
            {
                Brand = "Xiaomi",
                Model = "RedmiBook"
            };
        }

        public override EBook CreateEBook()
        {
            return new EBook
            {
                Brand = "Xiaomi",
                Model = "Mi Reader"
            };
        }

        public override Smartphone CreateSmartphone()
        {
            return new Smartphone
            {
                Brand = "Xiaomi",
                Model = "Redmi Note"
            };
        }
    }
}
