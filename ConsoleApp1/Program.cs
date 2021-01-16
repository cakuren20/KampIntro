using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200000;
            double faizOrani = 1.45;
            bool girisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azalmıs");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar artmıs");
            }
            else
            {
                Console.WriteLine("Dolar degismedi");
            }

            if (girisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
// write "cw" and press TAB twice. Nice trick