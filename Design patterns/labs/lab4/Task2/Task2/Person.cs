using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum PhysicalFitness { VeryFit, Fit, NotFit }

namespace Task2
{
    class Person
    {
        public string FullName;
        PhysicalFitness Fitness;
        IWorkOutable WorkOutType;
        public Person(string name, PhysicalFitness fitness)
        {
            FullName = name;
            Fitness = fitness;
            switch (Fitness)
            {
                case PhysicalFitness.VeryFit:
                    WorkOutType = new HardWorkOut();
                    break;
                case PhysicalFitness.Fit:
                    WorkOutType = new NormalWorkOut();
                    break;
                case PhysicalFitness.NotFit:
                    WorkOutType = new EasyWorkOut();
                    break;
            }
        }

        public void WorkOut()
        {
            WorkOutType.WorkOut();
        }

        public void ShowFitness()
        {
            Console.WriteLine(Fitness);
        }
    }
}
