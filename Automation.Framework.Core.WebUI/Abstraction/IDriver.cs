using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Abstraction
{
    public interface IDriver
    {
        IWebDriver GetWebDriver();
        void CloseBrowser();
        IAtWebElement FindElement(IAtBy iatBy);
        void NavigateTo(string url);
        string GetPageTitle();
        void GetNewTab();
        void CloseCurrentBrowser();
        void SwitchToWindowWithHandle(string handle);
        void SwitchToWindowWithTitle(string title);
        void SwitchToFrameWithName(string frameName);
        void Maximize();
        void ExecuteJavaScript(string script);
        void ScrollWithPixel();
        void ScrollByheight();
        void ScrollIntoView(IAtWebElement iatWebElement);
        string GetScreenShot();
        int FindElementsCount(IAtBy iatBy);
        string GetAlertMessage();
        bool IsAlertPresent();

        void CloseAllTabs();

        void ShowAlertMessage(string strNsg);
        Actions GetBuilderActions();



    }
}
