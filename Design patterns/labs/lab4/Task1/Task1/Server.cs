using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Server
    {
        IServerState Available;
        IServerState UnAvailable;
        IServerState State;

        public int MaxUsers=5;
        public int UsersCounter=0;
        public List<User> users=new List<User>();

        public Server()
        {
            this.Available = new Available(this);
            this.UnAvailable = new UnAvailable(this);

            State = this.Available;

            if (UsersCounter > MaxUsers)
            {
                State = this.UnAvailable;
            }
        }

        public void SetServerState(IServerState newServerState)
        {
            State = newServerState;
        }

        public void connectUser(User newUser)
        {
            State.ConnectUser(newUser);
        }

        public IServerState GetAvailableServerState() { return this.Available; }
        public IServerState GetUnAvailableServerState() { return this.UnAvailable; }
    }
}
