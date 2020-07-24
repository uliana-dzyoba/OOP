namespace Task1
{
    internal class Available : IServerState
    {
        private Server server;

        public Available(Server server)
        {
            this.server = server;
        }

        public void ConnectUser(User user)
        {
            server.users.Add(user);
            System.Console.WriteLine("User {0} connected", user.Fullname);
            server.UsersCounter++;

            if (server.UsersCounter == server.MaxUsers)
            {
                server.SetServerState(server.GetUnAvailableServerState());
                System.Console.WriteLine("Server is anavailable");
            }
        }
    }
}