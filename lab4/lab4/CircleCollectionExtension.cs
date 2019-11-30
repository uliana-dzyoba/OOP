using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static class CircleCollectionExtension
    {
        public static double WholeArea(this CircleCollection collection)
        {
            double area = 0;
            foreach(Circle c in collection.circles)
            {
                area += c.GetArea();
            }
            return area;
        }
    }
}
