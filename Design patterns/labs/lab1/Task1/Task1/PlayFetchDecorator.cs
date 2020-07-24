using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class PlayFetchDecorator : Decorator
    {
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("like playing fetch  ");
        }

        public override void DoActivity()
        {
            base.DoActivity();
            Console.WriteLine("Playing fetch");
        }

    }
}
