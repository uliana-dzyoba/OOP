using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Subscription
    {
        public string Fullname;
        public List<string> CurrentBooks;

        public Subscription(string fullname, List<string>currentBooks)
        {
            Fullname = fullname;
            CurrentBooks = currentBooks;
        }
    }
}
