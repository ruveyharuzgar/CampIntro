using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryTag = "Kategori";
            int numberOfStudents = 32000;
            double interestRate = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
                Console.WriteLine("Giriş Yap Butonu");


            Console.WriteLine(categoryTag);
            Console.ReadLine();
        }
    }
}
