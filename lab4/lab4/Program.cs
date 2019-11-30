using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab4
{
    class Program
    {
        static void Generations(CircleCollection collection)
        {

            Console.WriteLine("generation: " + GC.GetGeneration(collection));

            GC.Collect();
            GC.WaitForPendingFinalizers();
            collection.circles[1].PrintInfo(); //деструктор не викликається
            Console.WriteLine("generation: "+ GC.GetGeneration(collection));
            GC.Collect();
            GC.WaitForPendingFinalizers();
            collection.circles[2].PrintInfo(); //деструктор не викликається
            Console.WriteLine("generation: " + GC.GetGeneration(collection));
            GC.Collect();//виклик деструктора
        }

        static void WeakReferencing()
        {
            Circle strong = new Circle();
            Console.WriteLine("memory bytes provided now: "+ GC.GetTotalMemory(false));
            var weak = new WeakReference(strong, true);
            strong = null;
            GC.Collect();

            bool Alive = weak.IsAlive;

            if (Alive)
            {

                Console.WriteLine("The object is still alive");

                Circle restored = weak.Target as Circle;
                restored.PrintInfo();

            }
        }

        static void AutoCollecting(Circle[] array)
        {
            CircleCollection garbage = null;
            for (long i = 0; i < 49000; i++)
            {
                garbage = new CircleCollection(array);
            }

            garbage = null;

            Console.WriteLine("memory bytes provided now: " + GC.GetTotalMemory(false));
        }

        static void Main(string[] args)
        {
            Measurement.Unit = UnitsOfLength.mm;
            Console.WriteLine("memory bytes provided now: " + GC.GetTotalMemory(true) );
            //Circle c1 = new Circle(1, Color.Yellow);
            //Circle c2 = new Circle(2, Color.Red);
            //Circle c3 = new Circle(3, Color.Green);

            //Circle[] array = new Circle[3];
            //array[0] = c1;
            //array[1] = c2;
            //array[2] = c3;

            //простіша ініціалізація
            Circle[] array = new Circle[3] { new Circle(1, Color.Yellow), new Circle(2, Color.Red), new Circle(3, Color.Green) };

            CircleCollection collection = new CircleCollection(array);
            Console.WriteLine("memory bytes provided now: " + GC.GetTotalMemory(true));
            foreach (Circle c in collection)
            {
                c.PrintInfo();
            }

            //collection.Dispose(); //якщо не викликати використовується деструктор          

            //Generations(collection);
            //Circle circle = new Circle();
            //WeakReferencing();
            //GC.ReRegisterForFinalize(collection);
            //GC.ReRegisterForFinalize(collection);
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
            //AutoCollecting(array);
            Console.ReadKey();
        }
    }
}
