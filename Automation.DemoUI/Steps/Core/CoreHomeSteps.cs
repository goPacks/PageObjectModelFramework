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
    public class CoreHomeSteps
    {
        ICoreHomePage _iPage;

        public CoreHomeSteps(ICoreHomePage iPage)
        {
            _iPage = iPage;
        }


        [Then(@"I click on Core Home Menu label ""([^""]*)""")]
        public void ThenIClickOnCoreHomeMenuLabel(string menu)
        {
            Thread.Sleep(2000);
            _iPage.ClickMenu(menu);
        }

        [Then(@"I click on Core Home SubMenu label ""([^""]*)""")]
        public void ThenIClickOnCoreHomeSubMenuLabel(string subMenu)
        {
            Thread.Sleep(2000);
            _iPage.ClickSubMenu(subMenu);
        }






    }
}
