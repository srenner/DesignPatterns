using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configuration configuration = Configuration.Instance();

            Configuration configuration = null;

            Console.WriteLine("Favorite number is " + configuration.FavoriteNumber);

            Console.ReadKey();
        }
    }
}
