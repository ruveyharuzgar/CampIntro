using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names= new MyDictionary<string>();
            names.Add("Ayşe");
            names.Add("Ali");
            names.Add("Ahmet");

            foreach (var item in names.Show)
            {
                Console.WriteLine("Eklendi-> "+ item);
                Console.ReadLine();
            }

        }
    }
}
