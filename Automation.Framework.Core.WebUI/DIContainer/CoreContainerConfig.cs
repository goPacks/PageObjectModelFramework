using AngleSharp.Dom;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.DriverContext;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Report;
using Automation.Framework.Core.WebUI.Reports;
using Automation.Framework.Core.WebUI.Selenium.LocalWebDrivers;
using Automation.Framework.Core.WebUI.Selenium.WebDrivers;
using Automation.Framework.Core.WebUI.WebElements;
using BoDi;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using Microsoft.Data.SqlClient;

namespace Automation.Framework.Core.WebUI.DIContainer
{
    public class CoreContainerConfig
    {




        public static IServiceProvider ConfigureService()
        {
           
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IDefaultVariables, DefaultVariables>();
            serviceCollection.AddSingleton<ILogging, Logging>();
            serviceCollection.AddSingleton<IGlobalProperties, GlobalProperties>();
            serviceCollection.AddSingleton<IExtentFeatureReport, ExtentFeatureReport>();
            serviceCollection.AddTransient<IExtentReport, ExtentReport>();


            
            //serviceCollection.AddSingleton<SqlConnection>(provider =>
            //{
            //    var connectionString = "Server = localhost\\SQLEXPRESS; Database = mtra; Trusted_Connection = True; ";
            //    return new SqlConnection(connectionString);
            //});



            return serviceCollection.BuildServiceProvider();



        }

        public static IObjectContainer SetContainer(IObjectContainer iobjectContainer)
        {
            iobjectContainer.RegisterTypeAs<ChromeWebDriver, IChromeWebDriver>();
            iobjectContainer.RegisterTypeAs<FirefoxWebDriver, IFirefoxWebDriver>();
            iobjectContainer.RegisterTypeAs<Driver, IDriver>();
            iobjectContainer.RegisterTypeAs<AtBy, IAtBy>();
            
            iobjectContainer.RegisterTypeAs<AtWebElement, IAtWebElement>();
            
            return iobjectContainer;
        }
    }
}
