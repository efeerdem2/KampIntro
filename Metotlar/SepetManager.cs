using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
     class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + product.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
