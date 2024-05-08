using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Karakterer(string navn, int fagkode, int karakter)
    {
        private string _student = navn;
        private int _fagkode = fagkode;
        private int _karakter = karakter;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_student}");
            Console.WriteLine($"Fagkode: {_fagkode}");
            Console.WriteLine($"Karakter: {_karakter}");
        }

        public int grade()
        {
            return _karakter;
        }
    }
}
