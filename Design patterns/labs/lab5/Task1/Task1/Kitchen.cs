using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Kitchen
    {
        Chef chef1 = new SaladChef();
        Chef chef2 = new MeatChef();
        Chef chef3 = new SoupChef();
        Chef chef4 = new SauceChef();
        Chef chef5 = new DessertChef();

        public Kitchen()
        {
            chef1.setNextChef(chef2);
            chef2.setNextChef(chef3);
            chef3.setNextChef(chef4);
            chef4.setNextChef(chef5);
        }

        public void CookOrder(List<Dish> order)
        {
            chef1.Cook(order);
        }
    }
}
