using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLER
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Ekle( int sayi)
        {
            sayi = 99;
        }

        public int Ekle2(int sayi)
        {
            
            return sayi + 10;
        }
    }
}
