using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
            Console.ReadLine();

        }

        public void Random()
        {
            throw new NotImplementedException();
        }
    }
}
