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
            InternetConnection internetConnection = InternetConnection.getInstance("Lanet", 35.7, 5);
            List<User> administrationUsers = new List<User>();
            User admin = new User(null, "127.0.0.1", "Admin", "admin@gmail.com", internetConnection);
            User moderator = new User(null, "127.0.0.1", "Moderator", "moderator@gmail.com", internetConnection);
            administrationUsers.Add(admin);
            administrationUsers.Add(moderator);
            Network network = new Network(internetConnection, administrationUsers);
            network.AddUser("Ann Smith", "annsmith@gmail.com");
            network.AddUser("Noah Johnson", "noahjohnson@gmail.com");
            internetConnection.Provider = "Volia";
            internetConnection.Speed = 30.1;
            network.ShowInfo();
            Console.ReadKey();
        }
    }
}
