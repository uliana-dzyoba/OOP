namespace Task1
{
    internal class UnAvailable : IServerState
    {
        private Server server;

        public UnAvailable(Server server)
        {
            this.server = server;
        }

        public void ConnectUser(User user)
        {
            System.Console.WriteLine("Server is unavailable. Can't connect user {0}", user.Fullname);
        }
    }
}