using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class ResizeException:ArgumentOutOfRangeException
    {
        public double Percentage { get; }
        public ResizeException(string message, double value):base (message)
        {
            Percentage = value;
        }
    }
}
