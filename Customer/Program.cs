using System;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Adi = "Cagatay";
            customer1.Soyadi = "Akuren";
            customer1.KrediMiktari = 15000;
            customer1.Maasi = 5000;

            Customer customer2 = new Customer();
            customer2.Adi = "Cagri";
            customer2.Soyadi = "Akuren";
            customer2.KrediMiktari = 30000;
            customer2.Maasi = 10000;


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customer1.KrediMiktari = 25000;
            customerManager.Update(customer1);
            customerManager.Delete(customer2);

        }
    }
}
