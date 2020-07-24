using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User:IUser
    {
        public InternetConnection InternetConnection;

        public string IP;
        public string Name;
        public string Email;
        public List<User> connectedUsers;

        public User(List<User> connectedUsers, string ip, string name, string email, InternetConnection internetConnection)
        {
            IP = ip;
            Name = name;
            Email = email;
            this.connectedUsers = connectedUsers;
            InternetConnection = internetConnection;
        }

        public User Clone()
        {
            User clonedUser= (User)this.MemberwiseClone();
            List<User> clonedConnectedUsers = new List<User>(this.connectedUsers);
            return clonedUser;
        }

        public void ConnectToUser(User contact)
        {
            connectedUsers.Add(contact);
        }
    }
}
