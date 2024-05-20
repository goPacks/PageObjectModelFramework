using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction.Core
{
    public interface ICorePaymentPage
    {




        void CheckPageTitle(string pageTitle);

        void ClickOnSideMenu(string sideMenu);


        void SelfServiceBillingCodeCreation(string objectPermitNumber);


        void CheckBalanceTransferRequest();

        void SubmitBalanceTransferRequest(string requestNumber, string NPWP);

        void ManualCreationOfPayment(string TINNumber);

        //void MonitoringforOverpaymentandInterestCompensation();
    }
}
