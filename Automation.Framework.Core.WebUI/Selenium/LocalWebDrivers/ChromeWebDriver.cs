using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Runner;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation.Framework.Core.WebUI.Selenium.LocalWebDrivers
{
    public class ChromeWebDriver : IChromeWebDriver
    {
        IWebDriver iwebdriver;
        IGlobalProperties _iglobalProperties;
        public ChromeWebDriver()
        {
            _iglobalProperties = SpecflowRunner._iserviceProvider.GetRequiredService<IGlobalProperties>();
        }

        public IWebDriver GetChromeWebDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            iwebdriver = new ChromeDriver(GetOptions());
         //   iwebdriver.Manage().Window.Maximize();
            return iwebdriver;

            // To run on already opoened browser
            // "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9999 --user-data-dir="C:\data\project\ChromeProfile"
            // "C:\selenium\chrome\chrome-win64\chrome.exe" --remote-debugging-port=9999 --user-data-dir="C:\data\project\ChromeProfile"

        }
        public ChromeOptions GetOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;

          
       //     options.AddExtensions(@"EXTENSION PATH");


          

            if (_iglobalProperties.browserport != "")
            {
                options.DebuggerAddress = _iglobalProperties.browserport;
                
            }
            else
            {
                options.AddExcludedArgument("enable-automation");
                //   options.AddArgument("disable-extensions");
                options.AddArgument("disable-infobars");
                options.AddArgument("disable-notifications");
                options.AddArgument("disable-web-security");
                options.AddArgument("dns-prefetch-disable");
                options.AddArgument("disable-browser-side-navigation");
                options.AddArgument("disable-gpu");
                options.AddArgument("always-authorize-plugins");
                options.AddArgument("load-extension=src/main/resources/chrome_load_stopper");
                options.AddUserProfilePreference("download.default_directory", _iglobalProperties.datasetlocation);

            }


            return options;
        }
    }
}
