namespace emne_3_Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {   //studenter
            Student student1 = new("kåre", 19, "studiespesialisering", 99);
            Student student2 = new("oskar", 19, "studiespesialisering", 100);

            //karakterliste
            Karakterer karakter1 = new(Fag.GetFag(0), 5);
            Karakterer karakter3 = new(Fag.GetFag(3), 6);
            Karakterer karakter4 = new(Fag.GetFag(5), 3);
            Karakterer karakter2 = new(Fag.GetFag(1), 4);
            Karakterer karakter5 = new(Fag.GetFag(2), 2);
            Karakterer karakter6 = new(Fag.GetFag(4), 3);

            student1.run(karakter1, karakter3, karakter4);
            student2.run(karakter2, karakter5, karakter6);
        }
    }
}
