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
            Client client1 = new Client("annsmith", "password1");
            Client client2 = new Client("milkyway", "password2");
            client1.Connect(client2, "password2");
            client1.SendDeleteVirusesCommand();
            client1.SendLogoffCommand();
            Console.WriteLine("");
            client2.Connect(client1, "password1");
            client2.SendDeleteVirusesCommand();
            client2.SendDiagnozeCommand();
            Console.ReadKey();
        }
    }
}
