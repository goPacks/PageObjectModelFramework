using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Framework.Core.WebUI.Base;
using Automation.DemoUI.WebAbstraction.Core;

namespace Automation.DemoUI.Pages.Core
{
    public class CoreLoginPage : TestBase, ICoreLoginPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;



        IAtBy byUserName => GetBy(LocatorType.Id, "username");
        IAtWebElement UserName => _idriver.FindElement(byUserName);

        IAtBy byPassword => GetBy(LocatorType.Id, "password");
        IAtWebElement Password => _idriver.FindElement(byPassword);

        //button[text()='LOGIN']

        IAtBy bySubmitBtn => GetBy(LocatorType.Xpath, "//button[text()='LOGIN']");
        IAtWebElement SubmitBtn => _idriver.FindElement(bySubmitBtn);

        public CoreLoginPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void NavigateTo(string URL)
        {
            _idriver.NavigateTo(URL);
        }

        public void CloseAllTabs()
        {
            _idriver.CloseAllTabs();
        }


        public void EnterCredentials(string username, string passWord)
        {

            if (_idriver.GetPageTitle() == "DJP Connect | Login")
            {
                UserName.SendKeys(username);
                Password.SendKeys(passWord);
            }
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }

        public void ClickLogin()
        {

            if (_idriver.GetPageTitle() == "DJP Connect | Login")
            {
                SubmitBtn.ClickWithJs();
            }
        }




    }
}
