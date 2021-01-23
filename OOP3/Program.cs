using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needLoanManager = new NeedLoanManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(needLoanManager,new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager> {needLoanManager,transportCreditManager};

            //applicationManager.CreditPreliminaryInformation(credits);

            Console.ReadLine();
        }
    }
}
