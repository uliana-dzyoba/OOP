using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Client:IClient
    {
        private Server server;
        internal Server Server { get => server; set => server = value; }
        public string Username;
        private string password;

        public Client(string username, string password)
        {
            Username = username;
            this.password = password;
        }

        public void SendCommand(string username, string password, string command)
        {
            server.SendCommand(this, username, password, command);
        }

        public void DoCommand(Client clientFrom, string command)
        {
            Console.WriteLine("Doing command {0} from {1}", command, clientFrom.Username);
        }

        public Boolean CheckPassword(string password)
        {
            if (this.password == password)
            {
                return true;
            }
            else return false;
        }
    }
}
