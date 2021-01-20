using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>{"Rüveyha", "Tuana","Engin"};
            //names.Add("Rüveyha");
            //names.Add("Tuana");
            //names.Add("Engin");
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names.Add("Ali");
            Console.WriteLine(names[3]);

            Console.ReadLine();

        }
    }
}
