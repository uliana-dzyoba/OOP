using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SauceChef:Chef
    {
        public override void Cook(List<Dish> order)
        {
            List<Dish> remainedOrder = new List<Dish>();
            foreach (Dish dish in order)
            {
                if (dish.Type == DishType.Sauce)
                {
                    Console.WriteLine("Cooked {0}", dish.Name);
                }
                else
                {
                    remainedOrder.Add(dish);
                }
            }
            if (remainedOrder.Any())
            {
                if (this.NextChef != null)
                {
                    this.NextChef.Cook(remainedOrder);
                }
                else
                {
                    throw new ApplicationException("Lacks next chef unrecognized dishes");
                }
            }
            else
            {
                Console.WriteLine("Order is cooked");
            }
        }
    }
}
