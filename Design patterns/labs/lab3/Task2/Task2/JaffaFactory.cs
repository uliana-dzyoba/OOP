using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class JaffaFactory : JuiceFactory
    {
        public override AppleJuice MakeAppleJuice()
        {
            return new JaffaAppleJuice();
        }

        public override GrapeJuice MakeGrapeJuice()
        {
            return new JaffaGrapeJuice();
        }

        public override OrangeJuice MakeOrangeJuice()
        {
            return new JaffaOrangeJuice();
        }
    }
}
