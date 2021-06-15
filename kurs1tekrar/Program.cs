using System;

namespace kurs1tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "SD";
            kurs1.IzlenmeOrani = 77;
            kurs1.KursAdi = "Python";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C";
            kurs2.IzlenmeOrani = 88;
            kurs2.Egitmen = "JO";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.IzlenmeOrani = 15;
            kurs3.Egitmen = "LT";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " : "  + kurs.KursAdi);
            }
        }
    }
}
