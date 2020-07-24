using System;

namespace Task2
{
    internal class Client
    {
        private string password;
        public string Username;
        ICommand logoffCommand;
        ICommand deleteVirusesCommand;
        ICommand diagnozeCommand;
        Client currentConnected;
        public Client(string username, string password)
        {
            Username = username;
            this.password = password;
        }
        public void Connect(Client client, string password)
        {
            if (client.CheckPassword(password)){
                this.logoffCommand = new LogoffComand(client);
                this.deleteVirusesCommand = new DeleteVirusesCommand(client);
                this.diagnozeCommand = new DiagnozeCommand(client);
                currentConnected = client;
                Console.WriteLine("{0} connected to {1}", this.Username, client.Username);
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }

        }

        public void SendLogoffCommand()
        {
            if (this.logoffCommand != null)
            {
                Console.WriteLine("Sending logoff command to {0}", currentConnected.Username);
                this.logoffCommand.Execute();
            }
            else
            {
                Console.WriteLine("Connect first");
            }
        }

        public void SendDeleteVirusesCommand()
        {
            if (this.deleteVirusesCommand != null)
            {
                Console.WriteLine("Sending delete viruses command to {0}", currentConnected.Username);
                this.deleteVirusesCommand.Execute();
            }
            else
            {
                Console.WriteLine("Connect first");
            }
        }

        public void SendDiagnozeCommand()
        {
            if (this.diagnozeCommand != null)
            {
                Console.WriteLine("Sending diagnoze command to {0}", currentConnected.Username);
                this.diagnozeCommand.Execute();
            }
            else
            {
                Console.WriteLine("Connect first");
            }
        }

        public Boolean CheckPassword(string password)
        {
            if (this.password == password)
            {
                return true;
            }
            else return false;
        }

        public void Logoff()
        {
            Console.Write(this.Username+": ");
            Console.WriteLine("Logged off account");
        }

        public void DeleteViruses()
        {
            Console.Write(this.Username + ": ");
            Console.WriteLine("All viruses deleted");
        }

        public void Diagnoze()
        {
            Console.Write(this.Username + ": ");
            Console.WriteLine("System is diagnozed");
        }
    }
}