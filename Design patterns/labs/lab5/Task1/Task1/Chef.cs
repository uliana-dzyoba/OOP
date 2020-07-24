using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Chef
    {
        private Chef nextChef;

        public Chef NextChef { get => nextChef; set => nextChef = value; }

        public void setNextChef(Chef nextChef)
        {
            this.nextChef = nextChef;
        }

        public abstract void Cook(List<Dish> order);
    }
}
