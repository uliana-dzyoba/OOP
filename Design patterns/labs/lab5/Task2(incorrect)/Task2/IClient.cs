using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IClient
    {
        void SendCommand(string username, string password, string command);
        void DoCommand(Client clientFrom, string command);
    }
}
