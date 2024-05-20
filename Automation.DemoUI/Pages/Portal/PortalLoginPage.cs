using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Portal;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;

namespace Automation.DemoUI.Pages.Portal
{
    public class PortalLoginPage : TestBase, IPortalLoginPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        IAtBy byUserName => GetBy(LocatorType.Id, "Username");
        IAtWebElement UserName => _idriver.FindElement(byUserName);

        IAtBy byPassword => GetBy(LocatorType.Id, "password");
        IAtWebElement Password => _idriver.FindElement(byPassword);

        IAtBy bySubmitBtn => GetBy(LocatorType.Xpath, "//button[@type='submit']");
        IAtWebElement SubmitBtn => _idriver.FindElement(bySubmitBtn);

        IAtBy byNewRegLink => GetBy(LocatorType.LinkText, "New Registration");
        IAtWebElement NewRegLink => _idriver.FindElement(byNewRegLink);




        public PortalLoginPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
          : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void NavigateTo(string URL)
        {
            _idriver.NavigateTo(URL);
        }

        public void EnterCredentials(string username, string passWord)
        {
            if (_idriver.GetPageTitle() != "Registration Portal")
            {
                UserName.SendKeys(username);
                Password.SendKeys(passWord);
            }

        }

        public void CheckPageTitle(string pageTitle)


        {


            if (_idriver.GetPageTitle() != "Registration Portal")
            {

                Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
            }
        }

        public void ClickLogin()
        {
            if (_idriver.GetPageTitle() != "Registration Portal")
            {
                SubmitBtn.Click();
            }

        }


        public void ClickNewReg()
        {

            NewRegLink.Click();
        }


    }
}
