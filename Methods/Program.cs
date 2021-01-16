using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya elmasi";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elmasi";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] {product1, product2};

            //type safe 
            foreach (Product product in products)  // products -> name of array,  producti -> a random name for elements, Product -> name of class
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-------------------------");

            }

            Console.WriteLine("------------METHODS------------");
            // method = function 
            // instance
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            // Ekle2 kullanissiz
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Yeşil Karpuz", 80, 27);
        }
    }
}

// do not repeat yourself
// clean code
// best practice