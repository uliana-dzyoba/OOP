using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Pet
    {
        protected string Name;
        protected int Height;
        protected int Weight;
        protected int Age;
        protected string Gender;
        protected string Breed;
        protected string Owner;

        public abstract void ShowInfo();
        public abstract void MakeSound();
        public abstract void DoActivity();
    }
}
