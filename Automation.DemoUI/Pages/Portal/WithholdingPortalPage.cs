using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Portal;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System.Xml;

namespace Automation.DemoUI.Pages.Portal
{
    public class WithholdingPortalPage: TestBase, IWithholdingPortalPage
    {

        IAtConfiguration _iatConfiguration;
        IDriver _idriver;


        IAtWebElement btnCreateEBU => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[contains(text(),'Create eBupot BPU')]"));

        IAtWebElement taxPeriodBox  => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#select-TaxPeriodCode .p-dropdown-label"));


        IAtWebElement taxPeriodPick => _idriver.FindElement(GetBy(LocatorType.Xpath, "//li[@aria-label='2020 January']"));


        IAtWebElement TIN => _idriver.FindElement(GetBy(LocatorType.Id, "input-TaxIdentificationNumber"));
        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".col-md-12 > .ng-star-inserted"));

        IAtWebElement x2 => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#select-BranchIdIncomeRecipient .p-dropdown-label"));
        //driver.FindElement(By.CssSelector(".col-md-12 > .ng-star-inserted")).Click();
        //driver.FindElement(By.CssSelector("#select-BranchIdIncomeRecipient .p-dropdown-label")).Click();


        //li[@aria-label='2020 January']
        //span[contains(text(),'Create eBupot BPU')]
        //driver.FindElement(By.CssSelector("#select-TaxPeriodCode .p-dropdown-label")).Click();
        //driver.FindElement(By.CssSelector(".p-element:nth-child(8) > .p-ripple")).Click();



        public WithholdingPortalPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }
       
        public void CreateEBUPOTBPU(string tin)
        {

            Thread.Sleep(3000);

            btnCreateEBU.Click();

            Thread.Sleep(3000);

            taxPeriodBox.Click();

            Thread.Sleep(1000);

            taxPeriodPick.Click();

            Thread.Sleep(1000);

            TIN.Click();


            //Thread.Sleep(1000);      Thread.Sleep(1000);
            TIN.SendKeys(tin);

            Thread.Sleep(1000);

            x1.Click();

            Thread.Sleep(1000);

            x2.Click(); 

          
        }

        public void CreationOfBillingCodeFromTaxReturnPortal(string tin)
        {

            Thread.Sleep(3000);

            btnCreateEBU.Click();

            Thread.Sleep(3000);

            taxPeriodBox.Click();

            Thread.Sleep(1000);

            taxPeriodPick.Click();

            Thread.Sleep(1000);

            TIN.Click();


            //Thread.Sleep(1000);      Thread.Sleep(1000);
            TIN.SendKeys(tin);

            //Thread.Sleep(1000);

            //x1.Click();

            //Thread.Sleep(1000);

            //x2.Click();

        }


    }
}

