using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Juice
    {
        internal double price;
        internal string package;
        internal double sugar;

        abstract public void Show();
    }
}
