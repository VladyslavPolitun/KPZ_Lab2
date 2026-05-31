using System;
using KPZ_Lab2.AbstractFactory;
using KPZ_Lab2.FactoryMethod;
using KPZ_Lab2.Singleton;
using KPZ_Lab2.Prototype;
using KPZ_Lab2.Builder;

namespace KPZ_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ABSTRACT FACTORY =====");
            Console.WriteLine();

            DeviceFactory iprone = new IProneFactory();
            DeviceFactory xiaomi = new XiaomiFactory();
            DeviceFactory balaxy = new BalaxyFactory();

            iprone.CreateLaptop().ShowInfo();
            iprone.CreateSmartphone().ShowInfo();

            xiaomi.CreateLaptop().ShowInfo();
            xiaomi.CreateSmartphone().ShowInfo();

            balaxy.CreateLaptop().ShowInfo();
            balaxy.CreateSmartphone().ShowInfo();

            Console.WriteLine();

            SubscriptionCreator website = new WebSite();
            SubscriptionCreator mobile = new MobileApp();
            SubscriptionCreator manager = new ManagerCall();

            website.CreateSubscription().ShowInfo();
            mobile.CreateSubscription().ShowInfo();
            manager.CreateSubscription().ShowInfo();

            Console.WriteLine("===== SINGLETON =====");

            Authenticator auth1 = Authenticator.GetInstance();
            Authenticator auth2 = Authenticator.GetInstance();

            Console.WriteLine(
                $"Same instance: {ReferenceEquals(auth1, auth2)}");

            Console.WriteLine();
            Console.WriteLine("===== PROTOTYPE =====");

            Virus parent = new Virus(10, 5, "Alpha", "Main");

            Virus child1 = new Virus(5, 2, "Beta", "Child");
            Virus child2 = new Virus(4, 1, "Gamma", "Child");

            Virus grandChild = new Virus(2, 1, "Delta", "GrandChild");

            child1.Children.Add(grandChild);

            parent.Children.Add(child1);
            parent.Children.Add(child2);

            Console.WriteLine("Original:");
            parent.Show();

            Console.WriteLine();

            Console.WriteLine("Clone:");

            Virus clone = parent.Clone();
            clone.Show();

            Console.WriteLine();

            Console.WriteLine("===== BUILDER =====");

            CharacterDirector director = new CharacterDirector();

            Character hero = director.CreateCharacter(new HeroBuilder());
            Character enemy = director.CreateCharacter(new EnemyBuilder());

            Console.WriteLine("Hero:");
            hero.ShowInfo();

            Console.WriteLine("Enemy:");
            enemy.ShowInfo();

            Console.ReadKey();
        }
    }
}
