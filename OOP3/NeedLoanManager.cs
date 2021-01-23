using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
            Console.ReadLine();
        }

        public void Random()
        {
            throw new NotImplementedException();
        }
    }
}
