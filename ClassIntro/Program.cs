using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Rüveyha";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kampı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 28;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Rüveyha Rüzgar";
            kurs2.İzlenmeOrani = 23;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }

    class Product
    {
    }
}
    
}
