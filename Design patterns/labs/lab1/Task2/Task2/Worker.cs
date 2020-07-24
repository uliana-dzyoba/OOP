using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker:SchoolComponent
    {
        int salary;
        public Worker(string name, int salary):base(name)
        {
            this.salary = salary;
        }

        public override void Add(SchoolComponent c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(SchoolComponent c)
        {
            throw new NotImplementedException();
        }

        public override int Pay(int budget)
        {
            return budget - this.salary;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + "  salary: " + salary.ToString());
        }
    }
}
