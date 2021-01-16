using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi: " + product.name);
        }

        /* EKLEME METODUNU BU ŞEKİLDE DENEDİM VE TÜM METODLARA YENİ PARAMETREYİ
         * TEK TEK GİRMEK İŞİMİ ZORLAŞTIRDI
         * ÖZELLİKLERE GİT STOK ADEDİ EKLE DAHA BASİT
        ---ayrı ayrı yazmayıp ürün sınıfına yazmam ENCAPSULATİON dur------

        public void Add2(string productName, string explanation,double price,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + productName);
        }
        */
    }
}
