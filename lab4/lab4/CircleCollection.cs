using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace lab4
{
    [Serializable]
    class CircleCollection:IEnumerable, IEnumerator
    {
        public Circle[] circles=new Circle[1];
        //public CircleCollection(Circle[] array, int length)
        //{
        //    this.circles = array;
        //}
        public CircleCollection(Circle[] array)//не передаємо непотрібний параметр
        {
            this.circles = array;
        }
        public Circle this[Color color]
        {
            get
            {
                foreach (Circle c in circles)
                {
                    if (c.FillColor == color)
                        return c;
                }
                return null;
                
            }

            set
            {
                for(int i=0; i<circles.Length; i++)
                {
                    if (circles[i].FillColor == color)
                        circles[i]=value;
                }
            }

        }
            int position =-1;
        bool IEnumerator.MoveNext()
        {
            if(position<circles.Length-1)
            {
                position++;
                return true;
            }
            return false;
        }

        object IEnumerator.Current
        {
            get { return circles[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        //garbage

        private bool disposed = false;

        public void Dispose()
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
                    circles = null;
                }
                disposed = true;
            }
        }


        // Деструктор
        ~CircleCollection()
        {
            Console.Beep();
            Console.WriteLine("Circle Collection destructor");
            Dispose(false);
        }

    }
}
