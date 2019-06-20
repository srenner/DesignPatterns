using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Configuration
    {
        // todo see System.Lazy here: https://docs.microsoft.com/en-us/dotnet/api/system.lazy-1?view=netcore-2.2 
        private static readonly Lazy<Configuration> _lazyConfig = new Lazy<Configuration>(() => new Configuration());

        public int FavoriteNumber { get { return 6; } }

        public static Configuration Instance { get { return _lazyConfig.Value; } }

        private Configuration()
        {
            //need this constructor so other classes can't mistakenly write var config = new Configuration();
        }
    }
}
