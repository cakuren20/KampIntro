using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention, first letter is capital
        //syntax - yazım tarzı
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + product.Adi);


        }

        // class ın önemi
        // do not use Ekle2, KULLANISSIZ
        public void Ekle2(string urunAdi, string Aciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunAdi);
        }
    }
}
