using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class LogoffComand:ICommand
    {
        Client executor;
        public LogoffComand(Client c)
        {
            executor = c;
        }
        public void Execute()
        {
            executor.Logoff();
        }
    }
}
