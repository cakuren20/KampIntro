using System;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Tebrikler! Musteri " + customer.Adi + " " + customer.Soyadi + " listeye eklendi.");
            Console.WriteLine("Musterinin kredi miktari: " + customer.KrediMiktari);
            Console.WriteLine("Musterinin maasi: " + customer.Maasi);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " adli kredi tutari guncellenmistir. Yeni miktar: " + customer.KrediMiktari);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri" + customer.Adi + " " + customer.Soyadi + " listeden silinmistir.");
        }
    }
}