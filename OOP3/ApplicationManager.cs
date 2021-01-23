using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager,List<ILoggerService> loggerService)
        {
            //interfaceyi referans aldığım için tüm kredi tiplerini hesaplayabilir
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (var LoggerService in loggerService)
            {
                LoggerService.Log();
            }
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {
            //Kredi Ön bilgilendirme
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
            Console.ReadLine();

        }
        
    }
}
