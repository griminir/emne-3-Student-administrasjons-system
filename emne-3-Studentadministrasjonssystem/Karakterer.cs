using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Karakterer( Fag fag, int karakter)
    {
        internal int _fagkode = fag._fagkode;
        internal int _karakter = karakter;
        internal int _studiepoeng = fag._studiepoeng;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {_fagkode}");
            Console.WriteLine($"Karakter: {_karakter}");
        }
    }
}
