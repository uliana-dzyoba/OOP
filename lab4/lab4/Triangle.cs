using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Triangle:Shape
    {
        //public List<Triangle> triangles = new List<Triangle>();
        private double a;
        private double b;
        private double c;
        public double A { get { return a; } set { a = Round(value, precision); } }
        public double B { get { return b; } set { b = Round(value, precision); } }
        public double C { get { return c; } set { c = Round(value, precision); } }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Round(Sqrt(p*(p-a)*(p-b)*(p-c)), precision);
        }

        public override double GetPerimeter()
        {
            return Round(a + b + c, precision);
        }

        public Triangle()
        {
            a = 10;
            b = 20;
            c = 15;
        }

        public Triangle(double x, double y, double a, double b, double c) : base(x, y)
        {
            this.a = Round(a, precision);
            this.b = Round(b, precision);
            this.c = Round(c, precision);
        }

        public Triangle(double a, double b, double c)
        {
            this.a = Round(a, precision);
            this.b = Round(b, precision);
            this.c = Round(c, precision);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("triangle");
            Console.WriteLine(" a=" + Round(a*Measurement.Coef, precision) + Measurement.Unit + " b=" + Round(b * Measurement.Coef, precision) + Measurement.Unit + " c=" + Round(c * Measurement.Coef, precision) + Measurement.Unit);
            base.PrintInfo();
            Console.WriteLine(" area: " + Round(GetArea()*Measurement.Coef, precision) + " square " + Measurement.Unit);
            Console.WriteLine("--------\n");
        }
    }
}
