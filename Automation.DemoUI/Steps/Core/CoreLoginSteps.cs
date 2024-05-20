using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps.Core
{
    [Binding]
    public class CoreLoginSteps
    {

        ICoreLoginPage _iLoginCorePage;

        public CoreLoginSteps(ICoreLoginPage iLoginCorePage)
        {
            _iLoginCorePage = iLoginCorePage;
        }


        [Given(@"I navigate to CtasCore at @""([^""]*)""")]
        public void GivenINavigateToCtasCoreAt(string URL)
        {

            _iLoginCorePage.CloseAllTabs(); 

            _iLoginCorePage.NavigateTo(URL);
        }

        [When(@"I will check if am on Core page titled ""([^""]*)""")]
        public void WhenIWillCheckIfAmOnCorePageTitled(string title)
        {
            _iLoginCorePage.CheckPageTitle(title);
        }

        [Then(@"I enter ""([^""]*)"" as userId and ""([^""]*)"" as Password")]
        public void ThenIEnterAsUserIdAndAsPassword(string username, string password)
        {
            _iLoginCorePage.EnterCredentials(username, password);
        }

        [Then(@"I press Login Button")]
        public void ThenIPressLoginButton()
        {
            _iLoginCorePage.ClickLogin();
        }

        [Given(@"I move to CtasCore at @""([^""]*)""")]
        public void GivenIMoveToCtasCoreAt(string URL)
        {
            _iLoginCorePage.NavigateTo(URL);
        }



    }
}
