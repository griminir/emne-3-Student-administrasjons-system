using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
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
        private List<int> _fag = new List<int>();
        private int _totaleStudiePoeng;
        private List<Karakterer> _grades = new List<Karakterer>();

        private void SkrivUtInfo()
        {
            Console.WriteLine($"name: {_name}");
            Console.WriteLine($"age: {_age}");
            Console.WriteLine($"studieProgram: {_studieProgram}");
            Console.WriteLine($"studentId: {_studentId}");
            Console.WriteLine($"fag: {Fagloop()}");
            Console.WriteLine($"gjennomsnitt: {Gjennomsnitt()}");
            Console.WriteLine($"Studiepoeng: {_totaleStudiePoeng}");
        }

        private void GetStudentGrades(Karakterer grade1, Karakterer grade2, Karakterer grade3)
        {
            _grades.Add(grade1);
            _grades.Add(grade2);
            _grades.Add(grade3);
        }

        private void LeggTilFag()
        {
            foreach (var Code in _grades)
            {
                _fag.Add(Code._fagkode);
            }
        }

        private string Fagloop()
        {
            string fag = "";
            foreach (var f in _fag)
            {
                fag += f + " ";
            }
            return fag;
        }

        private float Gjennomsnitt()
        {
            float gjennomsnitt = 0;
            foreach (var grade in _grades)
            {
                gjennomsnitt += grade._karakter;
            }

            return gjennomsnitt/ _grades.Count;
        }

        private void TotaltStudiePoeng()
        {
            int sum = 0;
            foreach (var poeng in _grades)
            {
                sum += poeng._studiepoeng;
            }
            _totaleStudiePoeng = sum;
        }

        public void run(Karakterer grade1, Karakterer grade2, Karakterer grade3)
        {
            GetStudentGrades(grade1, grade2, grade3);
            LeggTilFag();
            TotaltStudiePoeng();
            SkrivUtInfo();
            Console.WriteLine();
        }
    }
}
