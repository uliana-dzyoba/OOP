using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab4
{
    [Serializable]
    abstract class Shape:IGeometry, IColor
    {
        public static readonly double Pi=PI;
        //public static int precision;
        private protected static int precision;//заміна модифікатора доступу для інкапсуляції

        private double x0;
        private double y0;
        private double angle;
        public double X0 { get { return x0; } set { x0=Round(value, precision); } }
        public double Y0 { get { return y0; } set { y0=Round(value, precision); } }
        public double Angle { get { return angle; } set { angle = Round(value, precision); } }
        public Color FillColor { get; set; } = Color.White;
        public Color BorderColor { get; set; } = Color.Black;

        static Shape()
        {
            precision = 4;
            Pi = Round(PI, precision);
        }

        public Shape() { }

        public Shape(double x, double y)
        {
            x0 = Round(x, precision);
            y0 = Round(y, precision);
        }

        public abstract double GetArea();//використовуємо поліморфізм, замість поля створюємо метод
        public abstract double GetPerimeter();

        public virtual void Resize(double percentage)
        {
            if (percentage<0)
            {
                throw new ResizeException("size can't be less than zero", percentage);
            }
        }

        public void Move(double dx, double dy)
        {
            Round(x0 += dx, precision);
            Round(y0 += dy, precision);
         
        }

        public void Rotate(double angle)
        {
            Round(this.angle += angle, precision);
        }

        void IColor.SetDefault()
        {
            Border(Color.Black);
            Fill(Color.White);
        }

        void IGeometry.SetDefault()
        {
            X0 = 0;
            Y0 = 0;
            Angle = 0;
        }

        public void Border(Color color)
        {
            BorderColor = color;
        }

        public void Fill(Color color)
        {
            FillColor = color;
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color.Name);
        }

        public virtual void PrintInfo()
        {
            //частина коду, спільна для всіх фігур
            Console.WriteLine("center: "+"("+x0+","+y0 + ")");
            Console.WriteLine("angle: " + angle);
            Console.WriteLine("fill: " + FillColor+" border: "+BorderColor);
        }

        //garbage

        private bool disposed = false;

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.Beep();
                    Console.WriteLine("disposing");
                }
                disposed = true;
            }
        }

        ~Shape()
        {
            Console.Beep();
            Console.WriteLine("Shape destructor");
            Dispose(false);
        }
    }
}
