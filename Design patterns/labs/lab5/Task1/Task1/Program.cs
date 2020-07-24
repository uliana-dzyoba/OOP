using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dish> order = new List<Dish> { new Dish("guacamole", DishType.Sauce), new Dish("tomato soup", DishType.Soup),
      new Dish("steak", DishType.MeatDish), new Dish("tiramisu", DishType.Dessert), new Dish("chiken shnitzel", DishType.MeatDish),
            new Dish("caesar", DishType.Salad), new Dish("caprese", DishType.Salad)};

            Console.Write("Order: ");
            foreach(Dish d in order)
            {
                Console.Write(d.Name+"  ");
            }
            Console.WriteLine("");
            Kitchen kitchen = new Kitchen();
            kitchen.CookOrder(order);
            Console.ReadKey();
        }
    }
}
