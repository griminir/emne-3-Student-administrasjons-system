namespace emne_3_Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {   //studenter
            Student student1 = new("kåre", 19, "studiespesialisering", 99);
            Student student2 = new("oskar", 19, "studiespesialisering", 100);

            //fagliste
            Fag fag1 = new(301, "historie og filosofi", 30);
            Fag fag2 = new(201, "historie", 15);
            Fag fag3 = new(101, "filosofi", 15);
            Fag fag4 = new(801, "programmering", 30);
            Fag fag6 = new(303, "streetfigthing", 5);
            Fag fag7 = new(505, "heimkunskap", 30);

            //karakterliste
            Karakterer karakter1 = new(student1.GetStudent(), fag1.GetFagKode(), 5);
            Karakterer karakter3 = new(student1.GetStudent(), fag4.GetFagKode(), 6);
            Karakterer karakter4 = new(student1.GetStudent(), fag7.GetFagKode(), 3);
            Karakterer karakter2 = new(student2.GetStudent(), fag2.GetFagKode(), 4);
            Karakterer karakter5 = new(student2.GetStudent(), fag3.GetFagKode(), 2);
            Karakterer karakter6 = new(student2.GetStudent(), fag6.GetFagKode(), 3);

            fag1.SkrivUtInfo();
            fag2.SkrivUtInfo();

            karakter1.SkrivUtInfo();
            karakter2.SkrivUtInfo();

            student1.LeggTilFag(fag1.GetFagKode(), fag4.GetFagKode(), fag7.GetFagKode());
            student2.LeggTilFag(fag2.GetFagKode(), fag3.GetFagKode(), fag6.GetFagKode());

            student1.GetStudentGrades(karakter1.grade(), karakter3.grade(), karakter4.grade());
            student2.GetStudentGrades(karakter2.grade(), karakter5.grade(), karakter6.grade());

            student1.TotaltStudiePoeng(fag1.GetStudiePoeng(), fag4.GetStudiePoeng(), fag7.GetStudiePoeng());
            student2.TotaltStudiePoeng(fag2.GetStudiePoeng(), fag3.GetStudiePoeng(), fag6.GetStudiePoeng());

            student1.SkrivUtInfo();
            student2.SkrivUtInfo();
        }
    }
}
