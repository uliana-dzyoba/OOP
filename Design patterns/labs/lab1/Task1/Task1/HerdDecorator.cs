using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class HerdDecorator : Decorator
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("shepherd  ");
        }

        public override void DoActivity()
        {
            base.DoActivity();
            Console.WriteLine("Herding livestock");
        }
    }
}
