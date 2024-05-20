using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;

namespace Automation.DemoUI.Pages
{


    public class GenericPage : TestBase, IGenericPage
    {


        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        public GenericPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;

        }

        public void CheckPageTitle(string pageTitle)
        {
            if (_idriver.GetPageTitle() != "DJP Connect | Login")
            {
                Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
            }


        }
    }

}

