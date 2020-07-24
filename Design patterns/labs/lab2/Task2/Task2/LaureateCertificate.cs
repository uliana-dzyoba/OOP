using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class LaureateCertificate:Certificate
    {
        protected int Place;
        public override void Fill(Contestant contestant)
        {
            this.FullName = contestant.FullName;
            this.School = contestant.School;
            this.Form = contestant.Form;
            this.Place = contestant.Place;
            Console.WriteLine("\n\n\tSHCOOL'S MUSIC ASSOCIATION\n\t\t{0}\n\tAward certificate\n\n    This certificate is awarded to \n\t\t{1}\n    {2} in {3}\n\t\tfor {4} place\n\n\t{5}\t{6}\n\t\t\tEvent Organizer\n\n",
                this.Contest, this.FullName, this.Form, this.School, this.Place, this.Date, this.Executive);
        }
    }
}
