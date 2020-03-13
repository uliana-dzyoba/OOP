using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Certificate
    {
        protected string Contest="Piano Master";
        protected string Executive="Ann Smith";
        protected string FullName;
        protected string School;
        protected string Form;
        protected string Date="14/03/20";

        public abstract void Fill(Contestant contestant);
    }
}
