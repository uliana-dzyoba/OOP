using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab4
{
    interface IColor
    {
        void Fill (Color color);
        void Border(Color color);
        void SetDefault();
    }
}
