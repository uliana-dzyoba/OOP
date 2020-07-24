using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class RichFactory : JuiceFactory
    {
        public override AppleJuice MakeAppleJuice()
        {
            return new RichAppleJuice();
        }

        public override GrapeJuice MakeGrapeJuice()
        {
            return new RichGrapeJuice();
        }

        public override OrangeJuice MakeOrangeJuice()
        {
            return new RichOrangeJuice();
        }
    }
}
