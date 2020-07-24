using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books1 = new List<string> { "Odyssey", "Gone with the wind", "Great Expectations" };
            List<string> books2 = new List<string> { };
            Subscription sub1 = new Subscription("Ann Smith", books1);
            Subscription sub2 = new Subscription("Noah Johnson", books2);
            List<Subscription> subs = new List<Subscription> { sub1, sub2 };
            OrganizedLibrary library = new OrganizedLibrary(subs);
            library.ESearch(sub1, "Looking for Alaska");
            library.ESearch(sub2, "Atomic habits");
            Console.ReadKey();
        }
    }
}
