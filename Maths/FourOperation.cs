using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class FourOperation
    {
        int sonuc = 0;
        public int Collection(int number1, int number2)
        {
            sonuc = number1 + number2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            return sonuc;
        }

        public double Extraction(int number1, int number2)
        {
            sonuc = number1 - number2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            return sonuc;
        }

        /*public void  Chamber
        {

        }
        public void Impact
        {

        }
        */

    }
}
