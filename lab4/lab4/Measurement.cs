using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum UnitsOfLength { m, dm, cm, mm, inch };
namespace lab4
{
    internal static class Measurement//зміна типу классу на статичний
    {
        static Action<UnitsOfLength> UnitsChange = (unit) => Console.WriteLine("units changed to "+unit);
        private static float InchInCm=0.3937f;//заміна числа константою, введення допоміжної змінної
        //private static float coef = 1;
        //public static float Coef
        //{
        //    get { return coef; }
        //    set { coef = value; }

        //}
        public static float Coef { get; set; } = 1;//заміна на автовластивість, введення допоміжної змінної
        private static UnitsOfLength unit= UnitsOfLength.cm;
        public static UnitsOfLength Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                switch (unit)
                {
                    case UnitsOfLength.m:
                        Coef = 0.01f;
                        break;
                    case UnitsOfLength.dm:
                        Coef = 0.1f;
                        break;
                    case UnitsOfLength.cm:
                        Coef = 1f;
                        break;
                    case UnitsOfLength.mm:
                        Coef = 10f;
                        break;
                    case UnitsOfLength.inch:
                        Coef = InchInCm;
                        break;
                }
                UnitsChange(unit);
            }
        }
        //static Measurement()видалення пустого конструктора
        //{
         
        //}
    }
}
