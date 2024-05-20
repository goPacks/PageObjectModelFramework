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
    public class WithholdingPortalSteps
    {

        IWithholdingPortalPage _iPage;

        public WithholdingPortalSteps(IWithholdingPortalPage iPage)
        {
            _iPage = iPage;
        }

       
        [Then(@"I will perform eBupot BPU wth TIN = ""([^""]*)"" on Portal Withholding page")]
        public void ThenIWillPerformEBupotBPUWthTINOnPortalWithholdingPage(string tin)
        {
            _iPage.CreateEBUPOTBPU(tin);
        }


        [Then(@"I will perform CcreationOfBillingcodeFromTaxReturnPortal wth TIN = ""([^""]*)"" on Portal Withholding page")]
        public void ThenIWillPerformCcreationOfBillingcodeFromTaxReturnPortalWthTINOnPortalWithholdingPage(string tin)
        {
            _iPage.CreationOfBillingCodeFromTaxReturnPortal(tin);
        }

    }
}