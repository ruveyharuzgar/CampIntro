using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names= new MyList<string>();
            names.Add("Rüveyha");
            names.Add("Rüzgar");
            names.Add("Engin");

            Console.WriteLine("toplam eleman sayısı: "+names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine("eklendi-> "+item);
            }

            Console.ReadLine();
        }
    }
}
