using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DeleteVirusesCommand:ICommand
    {
        Client executor;
        public DeleteVirusesCommand(Client c)
        {
            executor = c;
        }
        public void Execute()
        {
            executor.DeleteViruses();
        }
    }
}
