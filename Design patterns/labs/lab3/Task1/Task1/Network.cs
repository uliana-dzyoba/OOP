using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Network
    {
        public InternetConnection InternetConnection;
        public User templateUser;
        public List<User> AdministrationUsers;
        private List<User> users = new List<User>();

        public Network(InternetConnection internetConnection, List<User> administrationUsers)
        {
            InternetConnection = internetConnection;
            AdministrationUsers = administrationUsers;
            templateUser= new User(AdministrationUsers, "192.168.0.1", null, null, InternetConnection);
        }

        public void AddUser(string name, string email)
        {
            User newUser = templateUser.Clone();
            newUser.Name = name;
            newUser.Email = email;
            users.Add(newUser);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Users in network:\n");
            foreach(User user in users)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.IP);
                Console.WriteLine("Internet provider: "+user.InternetConnection.Provider);
                Console.WriteLine("Internet speed: " + user.InternetConnection.Speed);
                Console.WriteLine("Connected to "+user.Name+":");
                foreach(User connected in user.connectedUsers)
                {
                    Console.WriteLine(connected.Name);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
