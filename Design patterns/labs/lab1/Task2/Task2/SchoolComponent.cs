using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class SchoolComponent
    {
        protected string name;
        public SchoolComponent(string name)
        {
            this.name = name;
        }
        public abstract void Add(SchoolComponent c);
        public abstract void Remove(SchoolComponent c);        public abstract int Pay(int budget);        public abstract void Display(int depth);
    }
}
