namespace KPZ_Lab2.AbstractFactory
{
    public abstract class DeviceFactory
    {
        public abstract Laptop CreateLaptop();
        public abstract Netbook CreateNetbook();
        public abstract EBook CreateEBook();
        public abstract Smartphone CreateSmartphone();
    }
}
