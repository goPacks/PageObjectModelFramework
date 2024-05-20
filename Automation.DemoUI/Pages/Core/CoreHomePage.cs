using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Core;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace Automation.DemoUI.Pages.Core
{
    public class CoreHomePage : TestBase, ICoreHomePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        // Payment

        IAtWebElement PaymentMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Payment"));

        IAtWebElement BalTransferRequestSubMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Balance Transfer Request"));

        IAtWebElement ManualCreationOfPayments => _idriver.FindElement(GetBy(LocatorType.LinkText, "Manual Creation of Payments"));

        // -------------------------------------------------------------------------------------------------------------------------
        IAtWebElement SelfServiceBillingCodeCreation => _idriver.FindElement(GetBy(LocatorType.LinkText, "Self-Service Billing Code Creation"));

        IAtWebElement ReportsMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Reports"));

     //   IAtWebElement MonitoringForOverPaymentAndInterestCompensationOld => _idriver.FindElement(GetBy(LocatorType.LinkText, "Monitoring for Overpayment and Interest Compensation"));

        IAtWebElement MonitoringForOverPaymentAndInterestCompensation => _idriver.FindElement(GetBy(LocatorType.Xpath, "//a[contains(text(),'Monitoring for Overpayment and Interest Compensation')]"));

        IAtWebElement MonitoringForPaymentData => _idriver.FindElement(GetBy(LocatorType.Xpath, "//a[contains(text(),'Monitoring for Payment Data')]"));

        //  IAtWebElement subRptPayment  => _idriver.FindElement(GetBy(LocatorType.Xpath, "//a[contains(text(),'Payment')])[9]"));

        //ui-shared-header/nav[2]/ul[1]/li[20]/ul[1]/li[14]/a[1]

        IAtWebElement subRptPayment => _idriver.FindElement(GetBy(LocatorType.Xpath, "//ui-shared-header/nav[2]/ul[1]/li[20]/ul[1]/li[14]/a[1]"));

        IAtWebElement BalanceTransferReallocationRequestMonitoring  => _idriver.FindElement(GetBy(LocatorType.LinkText, "Balance Transfer Reallocation Request Monitoring"));

        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.Id, "3000"));


        //xpath=//a[contains(text(),'Monitoring for Overpayment and Interest Compensation')]
        public CoreHomePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
     : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }



        public void ClickMenu(string menu)
        {
            switch (menu)
            {
                case "Payment":
                    PaymentMenu.Click();
                    break;

                case "Reports":
                    ReportsMenu.Click();
                    break;
             

                default:
                    break;
            }

        }

        public void ClickSubMenu(string subMenu)
        {
            switch (subMenu)
            {
                case "Balance Transfer Request":
                    BalTransferRequestSubMenu.Click();
                    break;

                case "Self-Service Billing Code Creation":
                    SelfServiceBillingCodeCreation.Click();
                    break;

                case "Manual Creation of Payments":
                    ManualCreationOfPayments.Click();
                    break;
                
                case "Monitoring for Overpayment and Interest Compensation":
                    subRptPayment.MouseHover();
                    Thread.Sleep(3000);
                    MonitoringForOverPaymentAndInterestCompensation.Click();
                    break;
                case "Monitoring for Payment Data":
                    subRptPayment.MouseHover();
                    Thread.Sleep(1000);
                    MonitoringForPaymentData.MouseHover();
                    Thread.Sleep(1000);
                    MonitoringForPaymentData.Click();
                    break;

                case "Balance Transfer Reallocation Request Monitoring":
                    subRptPayment.MouseHover();
                    Thread.Sleep(1000);
                    BalanceTransferReallocationRequestMonitoring.MouseHover();
                    Thread.Sleep(1000);
                    BalanceTransferReallocationRequestMonitoring.Click();
                    break;

                default:
                    break;
            }
        }

    }
}
