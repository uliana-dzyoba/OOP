using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            Client client1 = new Client("annsmith", "password1");
            Client client2 = new Client("milkyway", "password2");
            server.AddClient(client1);
            server.AddClient(client2);
            client1.SendCommand("milkyway", "password", "save file");
            client1.SendCommand("milkyway", "password2", "save file");
            client1.SendCommand("sunny", "", "copy file");
            client2.SendCommand("annsmith", "password1", "delete logs");
            Console.ReadKey();
        }
    }
}
