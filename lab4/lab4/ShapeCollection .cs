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
    class ShapeCollection<T> :IEnumerable, IEnumerator where T:Shape
    {
        public T[] shapes=new T[1] { default(T) };
        public ShapeCollection(T[] array, int length)
        {
            this.shapes = array;
        }
        public T this[Color color]
        {
            get
            {
                foreach (T c in shapes)
                {
                    if (c.FillColor == color)
                        return c;
                }
                return null;
                
            }

            set
            {
                for(int i=0; i<shapes.Length; i++)
                {
                    if (shapes[i].FillColor == color)
                        shapes[i]=value;
                }
            }

        }
            int position =-1;
        bool IEnumerator.MoveNext()
        {
            if(position< shapes.Length-1)
            {
                position++;
                return true;
            }
            return false;
        }

        object IEnumerator.Current
        {
            get { return shapes[position]; }
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
                    shapes = null;
                }
                disposed = true;
            }
        }


        // Деструктор
        ~ShapeCollection()
        {
            Console.Beep();
            Console.WriteLine("Shape Collection destructor");
            Dispose(false);
        }
    }
}
