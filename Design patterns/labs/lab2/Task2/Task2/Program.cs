using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contestant> contestants = new List<Contestant> { new Contestant("Noah Johnson", "Echo Creek Academy", "sophomore", 3),
                new Contestant("Mary Evans", "Moordale High", "senior", 2), new Contestant("Thomas Brooks", "Shermer High School", "junior", 1), new Contestant("Karen Anderson", "Newport Union", "freshman", 0),
                new Contestant("Jessica Scott", "Rosewood High", "junior", 0), new Contestant("Brian Collins", "Rosewood High", "sophomore", 0) };
            CertificateFactory factory = new CertificateFactory();
            foreach(Contestant c in contestants)
            {
                Certificate certificate = factory.GetCertificate(c.Place);
                certificate.Fill(c);
            }
            Console.ReadKey();
        }
    }
}
