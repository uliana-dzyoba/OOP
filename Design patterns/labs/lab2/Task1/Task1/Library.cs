using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Library:ILibrary
    {
        public List<Subscription> Subscriptions;
        public void ESearch(Subscription sub, string searchString)
        {
            Console.WriteLine("searching " + searchString);
        }
 
    }
}
