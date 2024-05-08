using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Fag (int fagkode, string fagnavn, int studiepoeng)
    {
        private int _fagkode = fagkode;
        private string _fagnavn = fagnavn;
        private int _studiepoeng = studiepoeng;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"fagkode: {_fagkode}");
            Console.WriteLine($"fagnavn: {_fagnavn}");
            Console.WriteLine($"Studiepoeng: {_studiepoeng}");
        }

        public int GetFagKode()
        {
            return _fagkode;
        }

        public int GetStudiePoeng()
        {
            return _studiepoeng;
        }
    }
}
