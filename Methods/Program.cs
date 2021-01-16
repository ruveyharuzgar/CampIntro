using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.name = "Muz";
            product1.price = 15;
            product1.explanation = "Anamur Muzu";

            Product product2 = new Product();
            product2.name = "Karpuz";
            product2.price = 80;
            product2.explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.name);
                Console.WriteLine(product.price);
                Console.WriteLine(product.explanation);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("****Metotlar****");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            //basketManager.Add2("Armut","Yeşil armut",12);
            Console.ReadLine();
        }
    
}
    }
}
