using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class OrganizedLibrary:ILibrary
    {
        Library library = new Library();

        public OrganizedLibrary(List<Subscription> subscriptions)
        {
            library.Subscriptions = subscriptions;
        }

        public void ESearch(Subscription sub, string searchString)
        {
            if (sub.CurrentBooks.Count == 0)
                library.ESearch(sub, searchString);
            else
                Console.WriteLine("Return books first");
        }
    }
}
