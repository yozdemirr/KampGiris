using System;

namespace KampGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis oku");
            }
            else if (dolarDun< dolarBugun)
            {
                Console.WriteLine("artis oku");
            }
            else
            {
                Console.WriteLine("esittir");
            }


            if (sistemeGirmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

        }
    }
}
