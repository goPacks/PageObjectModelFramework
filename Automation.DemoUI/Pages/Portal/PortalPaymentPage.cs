using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Portal;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;

namespace Automation.DemoUI.Pages.Portal
{
    public class PortalPaymentPage : TestBase, IPortalPaymentPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .ng-star-inserted > #not\\ selected0 .p-checkbox-box"));

        IAtWebElement amount => _idriver.FindElement(GetBy(LocatorType.Id, "amount"));

        IAtWebElement x3 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".btn:nth-child(1)"));




        public PortalPaymentPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void AutoBalTransferFromTaxArrears()
        {

            x1.Click();
            amount.SendKeys("100");
            x3.Click();



        }


    }
}
