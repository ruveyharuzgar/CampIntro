using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "ali", "veli", "49", "50" };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i= " + i);

            }
            foreach (string i in courses)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}
