using AngleSharp.Dom;
using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Core;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using BoDi;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.ComponentModel;
using System;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Pages.Core
{
    public class CorePaymentPage : TestBase, ICorePaymentPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;
        FeatureContext _fc;
        string BalanceTransferAmnt = "";

        ILogging _ilogging;

        IAtWebElement CreateNewBalanceTransferRequestMenu => _idriver.FindElement(GetBy(LocatorType.Id, "842"));

        IAtWebElement RequestNumber => _idriver.FindElement(GetBy(LocatorType.Id, "request-number"));

        IAtWebElement elementDate => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".rounded-0"));


        IAtWebElement element1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-ink-active"));

        IAtWebElement RequestDate => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".rounded-0"));

        IAtWebElement RequestDatePick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-datepicker-buttonbar > .p-element:nth-child(1)"));

        IAtWebElement Channel => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#channel .p-dropdown-label"));

        IAtWebElement ChannelPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(2) > .p-ripple"));

        IAtWebElement TaxPayer => _idriver.FindElement(GetBy(LocatorType.Id, "Taxpayer"));

        IAtWebElement ObjectPermitNumber => _idriver.FindElement(GetBy(LocatorType.Id, "ObjectPermitNumber"));

        //    IAtWebElement ObjectPermitNumberSelect => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".col-sm-12 > .p-inputgroup > .p-button-warn"));


        IAtWebElement ObjectPermitNumberSelect => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[text()='Select']"));

        IAtWebElement SearchPaymentRecords => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".col-sm-12 > .p-inputgroup > .p-button-warn"));
        IAtWebElement PickPaymentRecord => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(1) #SetActive"));

        IAtWebElement PlaceHolder => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-placeholder"));

        //driver.FindElement(By.CssSelector(".p-element:nth-child(1) > .p-ripple")).Click();
        //driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(3) > .p-element .p-dropdown-label")).Click();

        IAtWebElement DestinationCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));
        IAtWebElement DestinationComboPickOld => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[@id='pr_id_78_label']"));


        IAtWebElement DestinationComboPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(3) > .p-element .p-dropdown-label"));


        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));



        //  IAtWebElement DestinationComboPick => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[text()='Taxpayer Account']"));

        //span[text()='Taxpayer Account']

        //  IAtWebElement RefCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(7) .p-dropdown-label"));

        IAtWebElement TaxLiabilityCombo => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[contains(text(),'Self Service')]"));



        // AmountToBeTransferred
        IAtWebElement AmountToBeTransferred => _idriver.FindElement(GetBy(LocatorType.Id, "AmountToBeTransferred"));

        IAtWebElement TaxPaymentCodeCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(3) > .p-dropdown-item"));

        IAtWebElement TaxPaymentCodeComboPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(1) > .p-element"));


        IAtWebElement Amount => _idriver.FindElement(GetBy(LocatorType.Id, "Amount0"));


        IAtWebElement ValidateRequestButton => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Validate Request']"));




        IAtWebElement taxLiability => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(6) .p-dropdown-trigger-icon"));

        IAtWebElement taxLiabilityPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(3) > .p-ripple"));

        IAtWebElement taxPaymentCode => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(8) .p-dropdown-trigger"));

        IAtWebElement taxPaymentCodePick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(2) > .p-ripple .mb-0"));


        IAtWebElement taxPeriod => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(9) .p-dropdown-trigger-icon"));

        IAtWebElement taxPeriodPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));

        IAtWebElement total => _idriver.FindElement(GetBy(LocatorType.Xpath, "//td[text()='Total']"));



        IAtWebElement submitBtn => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Submit Request']"));



        IAtWebElement validateBtn => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Validate Request']"));


        //-----------------------------------------------------------------------------------------------------------------------
        IAtWebElement ObjectPermitNumberBtn => _idriver.FindElement(GetBy(LocatorType.Id, "ObjectPermitNumber"));

        IAtWebElement selectCode => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-button-sm"));

        IAtWebElement a1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#TaxTypeTaxPayment .p-dropdown-label"));

        IAtWebElement revenueCodeFilter => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-dropdown-filter"));

        IAtWebElement a3 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(4) > .p-ripple"));

        IAtWebElement a4 => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#TaxPeriod .p-dropdown-label"));

        IAtWebElement taxPeriodFiler => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-dropdown-filter"));

        IAtWebElement taxPeriodPick2 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(12) .ng-star-inserted"));

        IAtWebElement AmountInput => _idriver.FindElement(GetBy(LocatorType.Id, "AmountInput"));

        IAtWebElement a5 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".form-group:nth-child(13) > .col-sm-9"));

        IAtWebElement a6 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".btn-primary"));

        //-------------------------------------------------------------------------------------------------
        IAtWebElement TINRow => _idriver.FindElement(GetBy(LocatorType.CssSelector, "td:nth-child(3) > .form-control"));

        IAtWebElement TIN => _idriver.FindElement(GetBy(LocatorType.CssSelector, "td > .ng-dirty"));
        IAtWebElement tblManualPay => _idriver.FindElement(GetBy(LocatorType.Id, "pr_id_4-table"));


        string css = "ui-coretax-one-column-layout.ng-star-inserted:nth-child(3) div.container-fluid div.row.main-content-container div.col-md-12.main-content pmnt-manual-payment-creation.ng-star-inserted:nth-child(2) form.ng-pristine.ng-invalid.ng-touched div.ng-pristine.ng-invalid.ng-touched p-table.p-element div.p-datatable-sm.p-datatable-gridlines.p-datatable-striped.p-datatable-responsiveness.p-datatable.p-component div.p-datatable-wrapper table.p-datatable-table.ng-star-inserted tbody.p-element.p-datatable-tbody tr.ng-pristine.ng-invalid.ng-star-inserted.ng-touched td:nth-child(3) > input.form-control.form-control-sm.ng-pristine.ng-invalid.is-invalid.ng-touched:nth-child(1)";

                    IAtWebElement xxxx=> _idriver.FindElement(GetBy(LocatorType.CssSelector, css));


        //driver.FindElement(By.CssSelector("td > .ng-dirty")).SendKeys("1091031210910452");
        //driver.FindElement(By.CssSelector(".col-md-12")).Click();

        // IAtWebElement sortAsc => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(8) .p-sortable-column-icon"));

        //IAtWebElement sortDesc => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".pi-sort-amount-up-alt"));

        //// 10 | click | css=.p-element:nth-child(8) .p-sortable-column-icon | 
        //driver.FindElement(By.CssSelector(".p-element:nth-child(8) .p-sortable-column-icon")).Click();
        //// 11 | click | css=.pi-sort-amount-up-alt | 
        //driver.FindElement(By.CssSelector(".pi-sort-amount-up-alt")).Click();

        //thead/tr[1]/th[8]/p-sorticon[1]/i[1]

        IAtWebElement sort => _idriver.FindElement(GetBy(LocatorType.Xpath, "//thead/tr[1]/th[8]/p-sorticon[1]/i[1]"));

        //      IAtWebElement transferValue  => _idriver.FindElement(GetBy(LocatorType.Xpath, "//tbody/tr[1]/td[5]"));


        IAtWebElement transferValue => _idriver.FindElement(GetBy(LocatorType.CssSelector, "ui-coretax-two-column-menu-left-layout.ng-star-inserted:nth-child(3) div.container-fluid div.row.main-content-container div.col-md-10.main-content pmnt-all-balance-transfer-request.ng-star-inserted:nth-child(2) ui-grid.ng-star-inserted:nth-child(2) p-table.p-element.ng-star-inserted:nth-child(1) div.scaled-datatable.p-datatable-sm.p-datatable-gridlines.p-datatable-striped.p-datatable-responsiveness.p-datatable.p-component.p-datatable-hoverable-rows.p-datatable-scrollable div.p-datatable-wrapper table.p-datatable-table.p-datatable-scrollable-table.p-datatable-resizable-table.ng-star-inserted tbody.p-element.p-datatable-tbody tr.ng-star-inserted:nth-child(1) > td.ng-star-inserted:nth-child(5)"));
        IAtWebElement tbl => _idriver.FindElement(GetBy(LocatorType.Id, "pr_id_16-table"));
        // IAtWebElement tblRow1 => _idriver.FindElement(GetBy(LocatorType.Xpath, "//tbody/tr[2]"));


        //----------------------------------------------------------
       
        // driver.FindElement(By.Id("3000")).Click();
    //    driver.FindElement(By.LinkText("Monitoring for Overpayment and Interest Compensation")).Click();


        // pr_id_16-table
        //tbody/tr[1]/td[5]

        //thead/tr[1]/th[8]/p-sorticon[1]/i[1]

        public CorePaymentPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver, FeatureContext fc)
        : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
            _fc = fc;
        }
        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }
        public void ClickOnSideMenu(string sideMenu)
        {
            switch (sideMenu)
            {
                case "Create New Balance Transfer Request":
                    CreateNewBalanceTransferRequestMenu.Click();
                    break;

                default:
                    break;
            }
        }

        //public string GetTableValue()
        ////{
        ////   System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allRows = tbl.GetElement().FindElements(By.TagName("tr"));

        ////    System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allCols = allRows[2].FindElements(By.TagName("td"));




        ////    string amount  = allCols[4].Text;



        

        ////}

        public void ManualCreationOfPayment(string TINNumber)
        {
            //TINRow.Click();

            //  TIN.SendKeys(TINNumber);

            //System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allRows = tblManualPay.GetElement().FindElements(By.TagName("tr"));


            //System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allCols = allRows[1].FindElements(By.TagName("td"));

            // allCols[2].SendKeys(TINNumber);



            //  allCols[2].Text = TINNumber;    

            xxxx.SendKeys(TINNumber);


        }


        public void SubmitBalanceTransferRequest(string requestNumber, string NPWP)
        {

            
            
            
            RequestNumber.SendKeys(requestNumber);

            RequestDate.Click();
            RequestDatePick.Click();

            Channel.Click();
            ChannelPick.Click();


            TaxPayer.Click();


            ObjectPermitNumber.SendKeys(NPWP);

            Thread.Sleep(3000);

            ObjectPermitNumberSelect.Click();

            Thread.Sleep(2000);

            SearchPaymentRecords.Click();

            Thread.Sleep(3000);

            PickPaymentRecord.Click();



            PlaceHolder.Click();

            // DestinationCombo.Click();


            // _idriver.ScrollIntoView(DestinationCombo);


            //DestinationCombo.MoveToElement();





            DestinationCombo.Click();

            DestinationComboPick.Click();

            Thread.Sleep(2000);

            try
            {
                x1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Thread.Sleep(2000);

            taxLiability.Click();

            Thread.Sleep(2000);

            taxLiabilityPick.Click();


            //laceHolder.Click();



            taxPaymentCode.Click();
            taxPaymentCodePick.Click();

            Thread.Sleep(2000);

            taxPeriod.Click();
            taxPeriodPick.Click();

            Thread.Sleep(2000);

            var amt = AmountToBeTransferred.GetAttribute("value");
            Amount.SendKeys(amt);
            BalanceTransferAmnt = amt;


            Thread.Sleep(2000);

            total.Click();

            Thread.Sleep(2000);

            validateBtn.ClickWithJs();

            Thread.Sleep(2000);

            submitBtn.ClickWithJs();

            _idriver.GetNewTab();

            _idriver.NavigateTo("https://ctas-mtra.intranet.pajak.go.id/home/en-US/");



            //-----------------------------------------------------------------------------------------
            // a5.Click();

            //  a6.Click();

            //sortAsc.Click();

            //sortDesc.Click();




        }



        public void CheckBalanceTransferRequest()
        {
            Thread.Sleep(5000);

            sort.Click();

            Thread.Sleep(5000);

            sort.Click();

            Thread.Sleep(5000);

            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allRows = tbl.GetElement().FindElements(By.TagName("tr"));


            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> allCols = allRows[2].FindElements(By.TagName("td"));


            string CheckAmount = allCols[4].Text;

            Assert.That(BalanceTransferAmnt, Is.EqualTo(CheckAmount));


            //            string amt1 = "0";
            //          string amt2 = "0";

            //amt1 =    transferValue.GetAttribute("value");

            //amt2 = transferValue.GetAttribute("text");


            //Assert.That(BalanceTransferAmnt, Is.EqualTo(amt2));


            // Now get all the TR elements from the table



            //var amnt = allRows[0].Text;

            //for (int i = 0; i < allRows.Count; i++) {
            //}


            
            //                   // And iterate over them, getting the cells
            //for (WebElement row : allRows)
            //{
            //    List<WebElement> cells = row.findElements(By.tagName("td"));
            //    for (WebElement cell : cells)
            //    {
            //        // And so on
            //    }
            //}


        }




        public void SelfServiceBillingCodeCreation(string objectPermitNumber)
        {
            ObjectPermitNumberBtn.SendKeys(objectPermitNumber);
            Thread.Sleep(5000);
            selectCode.Click();

            Thread.Sleep(3000);

            a1.Click();

            Thread.Sleep(1000);

            revenueCodeFilter.SendKeys("month");

            Thread.Sleep(1000);

            a3.Click();

            Thread.Sleep(1000);

            a4.Click();

            Thread.Sleep(1000);

            taxPeriodFiler.SendKeys("2020");

            taxPeriodPick2.Click();

            AmountInput.SendKeys("1100000");

            Thread.Sleep(1000);

            a5.Click();

            Thread.Sleep(1000);

            a6.Click();

            _idriver.GetNewTab();

            _idriver.NavigateTo("https://ctas-mtra.intranet.pajak.go.id/home/en-US/");


        }


        //public void act()
        //{


        // Actions builder =   _idriver.GetBuilderActions();
        //    builder.MoveToElement(elementNew.GetElement()).ClickAndHold().Perform();
        //}



    }





}
