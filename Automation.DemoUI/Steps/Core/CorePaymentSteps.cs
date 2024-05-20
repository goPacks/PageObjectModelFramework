using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction.Core;
using TechTalk.SpecFlow;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace Automation.DemoUI.Steps.Core
{
    [Binding]
    public class CorePaymentSteps
    {
        ICorePaymentPage _iPage;

        public CorePaymentSteps(ICorePaymentPage iPage)
        {
            _iPage = iPage;
        }



        [Then(@"I click on Create New Balance Transfer Request menu")]
        public void ThenIClickOnCreateNewBalanceTransferRequestMenu()
        {
            _iPage.ClickOnSideMenu("Create New Balance Transfer Request");
        }

        //[Then(@"I enter new request ""([^""]*)"" on  New Balance Transfer Request Details Form")]
        //public void ThenIEnterNewRequestOnNewBalanceTransferRequestDetailsForm(string requestNumber)
        //{
        //    _iPage.EnterRequestNumber(requestNumber);
        //}



        [Then(@"I will enter Tax Object Number ""([^""]*)"" in core payment page")]
        public void ThenIWillEnterTaxObjectNumberInCorePaymentPage(string objectPermitNumber)
        {
            _iPage.SelfServiceBillingCodeCreation(objectPermitNumber);

        }

        [Then(@"I will perform Self Service Billing with ""([^""]*)"" on Core Payment page")]
        public void ThenIWillPerformSelfServiceBillingWithOnCorePaymentPage(string number)
        {
            _iPage.SelfServiceBillingCodeCreation(number);

        }

        [When(@"I will check on Balance Transfer Request success")]
        public void WhenIWillCheckOnBalanceTransferRequestSuccess()
        {
            _iPage.CheckBalanceTransferRequest();
        }

        [Then(@"I enter New Request = ""([^""]*)"" and NPWP = ""([^""]*)"" on  New Balance Transfer Request Details Form")]
        public void ThenIEnterNewRequestAndNPWPOnNewBalanceTransferRequestDetailsForm(string requestNumber, string NPWP)
        {

            _iPage.SubmitBalanceTransferRequest(requestNumber, NPWP);
        }

        [Then(@"I will perform Manual Creation of Payments with TIN = ""([^""]*)"" on Core Payment page")]
        

        [Then(@"I will perform Manual Creation of Payment with TIN = ""([^""]*)"" on Core Payment page")]
        public void ThenIWillPerformManualCreationOfPaymentWithTINOnCorePaymentPage(string TIN)
        {
            _iPage.ManualCreationOfPayment(TIN);
        }


    }
}
