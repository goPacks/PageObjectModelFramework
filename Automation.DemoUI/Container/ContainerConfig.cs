using Automation.DemoUI.Configuration;
using Automation.DemoUI.Pages;
using Automation.DemoUI.Pages.Core;
using Automation.DemoUI.Pages.Portal;
using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Core;
using Automation.DemoUI.WebAbstraction.Portal;
using Automation.Framework.Core.WebUI.DIContainer;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Container
{
    [Binding]
    public class ContainerConfig
    {

        [BeforeScenario(Order =1)]
        public void BeforeScenario(IObjectContainer iobjectContainer)
        {

            iobjectContainer.RegisterTypeAs<GenericPage, IGenericPage>();
            iobjectContainer.RegisterTypeAs<PortalLoginPage, IPortalLoginPage>();
            iobjectContainer.RegisterTypeAs<CoreLoginPage, ICoreLoginPage>();
            iobjectContainer.RegisterTypeAs<PortalHomePage, IPortalHomePage>();
            iobjectContainer.RegisterTypeAs<CoreHomePage, ICoreHomePage>();
            iobjectContainer.RegisterTypeAs<CorePaymentPage, ICorePaymentPage>();
            iobjectContainer.RegisterTypeAs<PortalPaymentPage, IPortalPaymentPage>();
            iobjectContainer.RegisterTypeAs<WithholdingPortalPage, IWithholdingPortalPage>();
            iobjectContainer.RegisterTypeAs<AtConfiguration, IAtConfiguration>();

            
           
            iobjectContainer = CoreContainerConfig.SetContainer(iobjectContainer);


        }
    }
}
