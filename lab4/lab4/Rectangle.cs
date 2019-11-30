using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Rectangle:Shape
    {
        private double a;
        private double b;
        public double A { get { return a; } set { a=Round(value, precision); } }
        public double B { get { return b; } set { b=Round(value, precision); } }

        public override double GetArea()
        {
            return Round(a*b, precision);
        }

        public override double GetPerimeter()
        {
            return Round((a + b)*2, precision);
        }

        public Rectangle()
        {
            a = 10;
            b = 20;
        }

        public Rectangle (double x, double y, double a, double b) : base(x, y)
        {
            this.a = Round(a, precision);
            this.b = Round(b, precision);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("rectangle");
            Console.WriteLine(" a=" + Round(a*Measurement.Coef, precision) + Measurement.Unit + " b="+ Round(b*Measurement.Coef, precision) + Measurement.Unit);
            base.PrintInfo();
            Console.WriteLine(" area: " + Round(GetArea() * Measurement.Coef, precision) + " square " + Measurement.Unit);
            Console.WriteLine("--------\n");
        }
    }
}
