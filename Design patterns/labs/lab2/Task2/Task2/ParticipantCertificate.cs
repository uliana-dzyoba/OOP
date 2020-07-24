using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ParticipantCertificate:Certificate
    {
        protected int Place;
        public override void Fill(Contestant contestant)
        {
            this.FullName = contestant.FullName;
            this.School = contestant.School;
            this.Form = contestant.Form;
            Console.WriteLine("\n\n\tSHCOOL'S MUSIC ASSOCIATION\n\t\t{0}\n\tCertificate of Participation\n\n    This certificate is awarded to \n\t\t{1}\n    {2} in {3}\n\n\t{4}\t{5}\n\t\t\tEvent Organizer\n\n", 
                this.Contest, this.FullName, this.Form, this.School, this.Date, this.Executive);
        }
    }
}
