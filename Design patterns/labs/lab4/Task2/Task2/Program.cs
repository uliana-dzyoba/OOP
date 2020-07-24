using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ann Smith", PhysicalFitness.Fit);
            Person person2 = new Person("Noah Johnson", PhysicalFitness.VeryFit);
            Person person3 = new Person("James Williams", PhysicalFitness.NotFit);
            person1.ShowFitness();
            person1.WorkOut();
            Console.WriteLine();
            person2.ShowFitness();
            person2.WorkOut();
            Console.WriteLine();
            person3.ShowFitness();
            person3.WorkOut();
            Console.ReadLine();
        }
    }
}
