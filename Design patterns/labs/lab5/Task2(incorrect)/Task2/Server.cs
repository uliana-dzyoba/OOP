using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Server:IServer
    {
        List<Client> clients=new List<Client>();

        public void AddClient(Client newClient)
        {
            clients.Add(newClient);
            newClient.Server = this;
        }

        public void SendCommand(Client clientFrom, string username, string password, string command)
        {
            Client clientTo = clients.Find(c => c.Username == username);
            if (clientTo != null)
            {
                if (clientTo.CheckPassword(password))
                {
                    Console.WriteLine("sending command {0} to {1}", command, clientTo.Username);
                    clientTo.DoCommand(clientFrom, command);
                }
                else Console.WriteLine("incorrect password");
            }
            else Console.WriteLine("username doesn't exist");
        }
    }
}
