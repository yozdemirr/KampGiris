using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        //aşağısı bir methoddur pythondaki def.c# da normal parantez görürsek method çalısıyor deriz.
        public void Ekle(Urun urun) //ben ne ekleyeceğim ürün ekleyeceğim bunlar parametre olur büyük ürün tipi diğeri ise aşağıda onu kullanırken verdiğimiz isimlendirme
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
