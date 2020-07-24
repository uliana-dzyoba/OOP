using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            User user1 = new User("Ann Smith");
            User user2 = new User("Noah Johnson");
            User user3 = new User("Mary Evans");
            User user4 = new User("Thomas Brooks");
            User user5 = new User("James Williams");
            User user6 = new User("Jessica Scott");

            server.connectUser(user1);
            server.connectUser(user2);
            server.connectUser(user3);
            server.connectUser(user4);
            server.connectUser(user5);
            server.connectUser(user6);

            Console.ReadLine();
        }
    }
}
