using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IServer
    {
        void AddClient(Client newClient);
        void SendCommand(Client clientFrom, string username, string password, string command);
    }
}
