using System;

namespace MusteriTakipEtme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri must1 = new Musteri();
            must1.TcKimlik = 4565489564;
            must1.Ad = "Yusuf";
            must1.Soyad = "Ozdemir";

            Musteri must2 = new Musteri { TcKimlik = 85648151, Ad = "Ezel", Soyad = "Ozdemir" };

            Musteri must3 = new Musteri { TcKimlik = 9564234321, Ad = "Fatih", Soyad = "Ozdemir" };

            Musteri must4 = new Musteri { TcKimlik = 3654995421, Ad = "Meltem", Soyad = "Ozdemir" };

        }
    }
}
