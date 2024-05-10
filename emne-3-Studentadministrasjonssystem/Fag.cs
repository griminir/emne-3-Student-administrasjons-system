using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Fag (int fagkode, string fagnavn, int studiepoeng)
    {
        internal int _fagkode = fagkode;
        private string _fagnavn = fagnavn;
        internal int _studiepoeng = studiepoeng;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"fagkode: {_fagkode}");
            Console.WriteLine($"fagnavn: {_fagnavn}");
            Console.WriteLine($"Studiepoeng: {_studiepoeng}");
        }
    }
}
