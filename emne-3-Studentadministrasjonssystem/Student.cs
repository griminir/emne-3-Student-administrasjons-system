using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Studentadministrasjonssystem
{
    internal class Student(string name, int age, string studieProgram, int StudentId)
    {
        private string _name = name;
        private int _age = age;
        private string _studieProgram = studieProgram;
        private int _studentId = StudentId;
        private int[] _fag = [];
        private int[] _karakterer = [];
        private int _totaleStudiePoeng;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"name: {_name}");
            Console.WriteLine($"age: {_age}");
            Console.WriteLine($"studieProgram: {_studieProgram}");
            Console.WriteLine($"studentId: {_studentId}");
            Console.WriteLine($"fag: {_fag[0]}, {_fag[1]}, {_fag[2]}"); // loop? 
            Console.WriteLine($"gjennomsnitt: {Gjennomsnitt()}");
            Console.WriteLine($"Studiepoeng: {_totaleStudiePoeng}");
        }

        public string GetStudent()
        {
            return _name;
        }

        public void LeggTilFag(int førstefag, int andrefag, int tredjefag)
        {
            _fag = new int[] { førstefag, andrefag, tredjefag };
        }

        public void GetStudentGrades(int grade1, int grade2, int grade3)
        {
            _karakterer = new int[] { grade1, grade2, grade3 };
        }

        private float Gjennomsnitt()
        {
            float gjennomsnitt = _karakterer.Sum();
            return gjennomsnitt / _karakterer.Length;
        }

        public void TotaltStudiePoeng(int poeng1, int poeng2, int poeng3)
        {
            int sum = poeng1 + poeng2 + poeng3;
            _totaleStudiePoeng = sum;
        }
    }
}
