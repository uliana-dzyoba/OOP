using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    interface IGeometry
    {
        void Move(double dx, double dy);
        void Rotate(double angle);
        void SetDefault();
    }
}
