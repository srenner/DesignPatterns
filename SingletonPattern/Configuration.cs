using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Configuration
    {
        private static Configuration _instance;

        public int FavoriteNumber { get { return 6; } }

        protected Configuration()
        {

        }

        //not thread safe
        public static Configuration Instance()
        {
            if(_instance == null)
            {
                _instance = new Configuration();
            }
            return _instance;
        }
    }
}
