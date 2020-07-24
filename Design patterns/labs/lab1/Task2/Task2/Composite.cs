using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Composite:SchoolComponent
    {
        private List<SchoolComponent> _children = new List<SchoolComponent>();

        public Composite(string name):base(name)
        {
        }

        public override void Add(SchoolComponent component)
        {
            _children.Add(component);
        }
        public override void Remove(SchoolComponent component)
        {
            _children.Remove(component);
        }

        public override int Pay(int budget)
        {
            foreach (SchoolComponent component in _children)
                budget = component.Pay(budget);
            return budget;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (SchoolComponent component in _children)
                component.Display(depth + 2);
        }
    }
}
