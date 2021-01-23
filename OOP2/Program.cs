using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri
            İndiviculCustomer customer1 = new İndiviculCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Rüveyha";
            customer1.LastName = "Rüzgar";
            customer1.TcNumber = "12345678910";
            
            //Tüzel müşteri
            CorparateCustomer customer2 = new CorparateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxName ="12345678910";

            Customer customer3 = new İndiviculCustomer();
            Customer customer4 = new CorparateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            //3 ve 4 ü de ekleyebiliriz.Kalıtım uygulandı.
        }
    }
}
