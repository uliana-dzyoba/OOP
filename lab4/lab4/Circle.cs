using System;
using static System.Math;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [Serializable]
    class Circle:Shape, IComparable<Circle>
    {
        public delegate void Transformation();
        Transformation resizing = delegate () { Console.WriteLine("resizing"); };
        Func<double, double, double>Resizing=(r, per)=> r * (per / 100);
        private double r;
        public double R { get { return r; } set { r=Round(value, precision); } }

        public override double GetArea()
        {
            return Round(r*r * Pi, precision);
        }

        public override double GetPerimeter()
        {
            return Round(r * 2 * Pi, precision);
        }

        public override void Resize(double percentage)
        {
            base.Resize(percentage);
            r = Resizing(r, percentage);
            resizing();
        }


        public Circle()
        {
            r = 10;
        }

        public Circle(double r, Color color)
        {
            this.r = r;
            this.FillColor = color;
        }

        public Circle(double x, double y, double r):base( x, y)
        {
            this.r = Round(r, precision);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("circle");
            Console.WriteLine(" r=" + Round(r * Measurement.Coef, precision) + Measurement.Unit);
            base.PrintInfo();
            Console.WriteLine(" area: " + Round(GetArea() * Measurement.Coef, precision) + " square " + Measurement.Unit);
            Console.WriteLine("--------\n");
        }
        public int CompareTo(Circle c)
        {
            if (this.R > c.R)
                return 1;
            else if (this.R < c.R)
                return -1;
            else return 0;
        }

        //garbage

        private bool disposed = false;

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.Beep();
                    Console.WriteLine("disposing");
                }
                disposed = true;
                base.Dispose(disposing);
            }
        }

        ~Circle()
        {
            Console.Beep();
            Console.WriteLine("Circle destructor");
            Dispose(false);
        }
    }
}
