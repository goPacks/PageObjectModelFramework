using Automation.DemoUI.WebAbstraction.Portal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps.Portal
{
    [Binding]
    public class PortalLoginSteps
    {
        IPortalLoginPage _iLoginPage;

        public PortalLoginSteps(IPortalLoginPage iLoginPage)
        {
            _iLoginPage = iLoginPage;
        }



        //------------------------------------------------

        [Given(@"I navigate to TpPortal at @""([^""]*)""")]
        public void GivenINavigateToTpPortalAt(string p0)
        {
            _iLoginPage.NavigateTo(p0);
        }

        [When(@"I will check if am on page titled ""([^""]*)""")]
        public void WhenIWillCheckIfAmOnPageTitled(string pageTitle)
        {
            _iLoginPage.CheckPageTitle(pageTitle);
        }

        //[Then(@"I enter ""([^""]*)"" as TIN and ""([^""]*)"" as Password")]
        //public void ThenIEnterAsTINAndAsPassword(string tin, string password)
        //{
        //    _iLoginPage.EnterCredentials(tin, password);
        //}

        [Then(@"I will enter ""([^""]*)"" as TIN and ""([^""]*)"" as Password")]
        public void ThenIWillEnterAsTINAndAsPassword(string tin, string password)
        {
            _iLoginPage.EnterCredentials(tin, password);
        }


        [Then(@"I manually enter Captcha")]
        public void ThenIManuallyEnterCaptcha()
        {
            Thread.Sleep(10000);
        }



        [Then(@"I will click on Login Button")]
        public void ThenIWillClickOnLoginButton()
        {
            _iLoginPage.ClickLogin();
        }



        [Given(@"I click on New Registration")]
        public void GivenIClickOnNewRegistration()
        {
            _iLoginPage.ClickNewReg();
        }





    }
}
