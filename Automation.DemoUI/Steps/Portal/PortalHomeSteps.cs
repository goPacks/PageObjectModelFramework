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
    public class PortalHomeSteps
    {
        IPortalHomePage _iPage;

        public PortalHomeSteps(IPortalHomePage iPage)
        {
            _iPage = iPage;

        }

        [When(@"I click on Portal Home Menu label ""([^""]*)""")]
        public void WhenIClickOnPortalHomeMenuLabel(string menu)
        {
            _iPage.ClickMenu(menu);
        }

        [When(@"I click on Portal Home SubMenu label ""([^""]*)""")]
        public void WhenIClickOnPortalHomeSubMenuLabel(string subMenu)
        {
            _iPage.ClickSubMenu(subMenu);
        }




    }
}
