using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DiagnozeCommand:ICommand
    {
        Client executor;
        public DiagnozeCommand(Client c)
        {
            executor = c;
        }
        public void Execute()
        {
            executor.Diagnoze();
        }
    }
}
