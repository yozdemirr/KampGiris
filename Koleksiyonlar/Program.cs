using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Yusuf","Aslı","Fahri","Zesi" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            // Dizi bir veri kaynağından geldiğinde sen ona veri ekleyemezsin bu yüzden koleksiyonları kullanırız çünkü dizilerle çalışamayız
            // array yerine koleksiyon kullanıyorlar genelde

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            // isimler2.Add("Jo") jo'yu ekler.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
