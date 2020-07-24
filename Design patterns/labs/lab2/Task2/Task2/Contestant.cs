using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Contestant
    {
        public string FullName;
        public string School;
        public string Form;
        public int Place;
        public Contestant(string fullname, string school, string form, int place)
        {
            FullName = fullname;
            School = school;
            Form = form;
            Place = place;
        }
    }
}
