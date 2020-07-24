using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IUser
    {
        User Clone();
        void ConnectToUser(User contact);
    }
}
