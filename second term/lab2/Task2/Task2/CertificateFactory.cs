using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CertificateFactory
    {
        private Dictionary<int, Certificate> _certificates = new Dictionary<int, Certificate>();
        public Certificate GetCertificate(int key)
        {
            Certificate certificate = null;
            if (_certificates.ContainsKey(key))
            {
                certificate = _certificates[key];
            }
            else
            {
                if(key==1) certificate = new WinnerCertificate();
                else if(key==0) certificate = new ParticipantCertificate();
                else certificate = new LaureateCertificate();
                _certificates.Add(key, certificate);
            }
            return certificate;
        }
    }
}
