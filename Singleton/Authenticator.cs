using System;

namespace KPZ_Lab2.Singleton
{
    public sealed class Authenticator
    {
        private static Authenticator instance;
        private static readonly object locker = new object();

        private Authenticator()
        {
            Console.WriteLine("Authenticator created");
        }

        public static Authenticator GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new Authenticator();
                }

                return instance;
            }
        }
    }
}
