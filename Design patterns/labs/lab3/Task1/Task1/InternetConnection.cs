using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class InternetConnection
    {
        private static InternetConnection instance;

        public string Provider;
        public double Speed;
        public int Ping;

        protected InternetConnection(string provider, double speed, int ping)
        {
            Provider = provider;
            Speed = speed;
            Ping = ping;
        }

        public static InternetConnection getInstance(string provider, double speed, int ping)
        {
            if (instance == null)
                instance = new InternetConnection(provider, speed, ping);
            return instance;
        }
    }
}
