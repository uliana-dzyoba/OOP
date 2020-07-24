using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Decorator : Pet
    {
        protected Pet DecoratedPet;
        public void Decorate(Pet decoratedPet)
        {
            this.DecoratedPet = decoratedPet;
        }

        public override void ShowInfo()
        {
            if (DecoratedPet != null) DecoratedPet.ShowInfo();
        }

        public override void MakeSound()
        {
            if (DecoratedPet != null) DecoratedPet.MakeSound();
        }

        public override void DoActivity()
        {
            if (DecoratedPet != null) DecoratedPet.DoActivity();
        }
    }
}
