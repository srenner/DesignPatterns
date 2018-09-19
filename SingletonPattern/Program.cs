using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration configuration = Configuration.Instance;
            Console.WriteLine("Favorite number is " + configuration.FavoriteNumber);
            Console.ReadKey();
        }
    }
}
