using Automation.DemoUI.Configuration;
using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Portal;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automation.DemoUI.Pages.Portal
{
    public class PortalHomePage : TestBase, IPortalHomePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        //    IAtBy byETaxInvoiceMenu => GetBy(LocatorType.LinkText, "eTax Invoice");
        IAtWebElement ETaxInvoiceMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "eTax Invoice"));

        IAtWebElement PaymentMenu => _idriver.FindElement(GetBy(LocatorType.Id, "82"));

        IAtWebElement taxArrears => _idriver.FindElement(GetBy(LocatorType.LinkText, "Tax Arrears Billing Code"));

        IAtWebElement eBUPPOT => _idriver.FindElement(GetBy(LocatorType.LinkText, "eBUPOT (Withholding Slips)"));

        IAtWebElement BPU => _idriver.FindElement(GetBy(LocatorType.LinkText, "BPU"));


        public PortalHomePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
           : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }

        public void ClickMenu(string menu)
        {
            switch (menu)
            {
                case "Output Tax":
                    ETaxInvoiceMenu.Click();
                    break;
                case "Payment":
                    PaymentMenu.Click();
                    break;

                case "Tax Arrears Billing Code":
                    taxArrears.Click();
                    break;

                case "eBUPOT (Withholding Slips)":
                    eBUPPOT.Click(); 
                    break;  

                default:
                    break;
            }

        }



        public void ClickSubMenu(string subMenu)
        {
            switch (subMenu)
            {

                case "Tax Arrears Billing Code":
                    taxArrears.Click();
                    break;

                case "BPU":
                    BPU.Click();
                    break;

                default:
                    break;
            }

        }
    }
}
