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
            Karakterer karakter1 = new(fag1, 5);
            Karakterer karakter3 = new(fag4, 6);
            Karakterer karakter4 = new(fag7, 3);
            Karakterer karakter2 = new(fag2, 4);
            Karakterer karakter5 = new(fag3, 2);
            Karakterer karakter6 = new(fag6, 3);

            student1.run(karakter1, karakter3, karakter4);
            student2.run(karakter2, karakter5, karakter6);
        }
    }
}
