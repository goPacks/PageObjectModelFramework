using Automation.DemoUI.WebAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps
{
    [Binding]
    public class GenericSteps
    {

        IGenericPage _iPage;

        public GenericSteps(IGenericPage iPage)
        {
            _iPage = iPage;
        }

        [When(@"I am on page titled ""([^""]*)""")]
        public void WhenIAmOnPageTitled(string pageTitle)
        {
            _iPage.CheckPageTitle(pageTitle);
        }

    }
}
