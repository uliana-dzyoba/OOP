using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class JuiceFactory
    {
        public abstract AppleJuice MakeAppleJuice();
        public abstract GrapeJuice MakeGrapeJuice();
        public abstract OrangeJuice MakeOrangeJuice();
    }
}
