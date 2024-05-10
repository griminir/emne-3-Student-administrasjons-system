using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Fag (int fagkode, string fagnavn, int studiepoeng)
    {
        internal int _fagkode = fagkode;
        private string _fagnavn = fagnavn;
        internal int _studiepoeng = studiepoeng;
        private static List<Fag> _faglist = LagFag();

        public void SkrivUtInfo()
        {
            Console.WriteLine($"fagkode: {_fagkode}");
            Console.WriteLine($"fagnavn: {_fagnavn}");
            Console.WriteLine($"Studiepoeng: {_studiepoeng}");
        }

        internal static List<Fag> LagFag()
        {
            List<Fag> Faglist = new List<Fag>();

            Fag fag1 = new(301, "historie og filosofi", 30);
            Fag fag2 = new(201, "historie", 15);
            Fag fag3 = new(101, "filosofi", 15);
            Fag fag4 = new(801, "programmering", 30);
            Fag fag6 = new(303, "streetfigthing", 5);
            Fag fag7 = new(505, "heimkunskap", 30);

            Faglist.Add(fag1);
            Faglist.Add(fag2);
            Faglist.Add(fag3);
            Faglist.Add(fag4);
            Faglist.Add(fag6);
            Faglist.Add(fag7);

            return Faglist;
        }

        public static Fag GetFag(int number)
        {
            return _faglist[number];
        }
    }
}
