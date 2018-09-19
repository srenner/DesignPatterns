using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Configuration
    {
        private static readonly Lazy<Configuration> _lazyConfig = new Lazy<Configuration>(() => new Configuration());

        public int FavoriteNumber { get { return 6; } }

        public static Configuration Instance { get { return _lazyConfig.Value; } }

        private Configuration()
        {
            //need this constructor so other classes can't mistakenly write var config = new Configuration();
        }
    }
}
