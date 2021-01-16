using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;

            int[] array = new int[] { 10, 20, 30 };
            int[] array2 = new int[] { 100, 200, 300 };
            array = array2;
            array2[0] = 999;

            Console.WriteLine(number1);
            Console.WriteLine(array[0]);
            Console.ReadKey();
        }
    }
}
