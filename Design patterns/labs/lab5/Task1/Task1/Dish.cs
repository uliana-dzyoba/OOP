using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DishType { Salad, MeatDish, Soup, Sauce, Dessert}

namespace Task1
{
    public class Dish
    {
        public string Name;
        public DishType Type;

        public Dish(string name, DishType type)
        {
            Name = name;
            Type = type;
        }
    }
}
