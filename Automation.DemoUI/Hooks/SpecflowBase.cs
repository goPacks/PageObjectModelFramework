using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Runner;
using BoDi;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Hooks
{
    [Binding]
    public class SpecflowBase
    {
        IGlobalProperties _iglobalProperties;
        IChromeWebDriver _ichromeWebDriver;
        IFirefoxWebDriver _ifirefoxDriver;
        IDriver _idriver;
        ILogging _ilogging;
        public SpecflowBase(IChromeWebDriver ichromeWebDriver, IFirefoxWebDriver ifirefoxWebDriver)
        {
            _ichromeWebDriver = ichromeWebDriver;
            _ifirefoxDriver = ifirefoxWebDriver;
        }

        [BeforeScenario(Order = 2)]
        public void BeforeScenario(IObjectContainer iobjectContainer, ScenarioContext sc, FeatureContext fc)
        {

            _idriver = iobjectContainer.Resolve<IDriver>();
            //IExtentReport extentReport = (IExtentReport)fc["iextentreport"];
            //extentReport.CreateScenario(sc.ScenarioInfo.Title);
            sc["step"] = "1";
            
        }

        [AfterStep]
        public void AfterSteps(ScenarioContext sc, FeatureContext fs)
        {
           // IExtentReport extentReport = (IExtentReport)fs["iextentreport"];
            _ilogging = SpecflowRunner._iserviceProvider.GetRequiredService<ILogging>();
            string strStepInfo = sc.StepContext.StepInfo.Text;

            if (sc.TestError != null)
            {
                string base64 = null;
                base64 = _idriver.GetScreenShot();
                //extentReport.Fail(sc.StepContext.StepInfo.Text, base64);
                //_ilogging = SpecflowRunner._iserviceProvider.GetRequiredService<ILogging>();

                _ilogging.Error(sc.ScenarioInfo.Title + "," +   sc["step"] + "," + strStepInfo + "," + sc.TestError.Message.Replace("\n", "").Replace("\r", "") + "," + base64);
               // _ilogging.Error(base64);






            }
            else
            {
                IGlobalProperties iglobalProperties = SpecflowRunner._iserviceProvider.GetRequiredService<IGlobalProperties>();
                string base64 = null;
                if (iglobalProperties.stepscreenshot)
                {
                    base64 = _idriver.GetScreenShot();
                }

               

                
                if (strStepInfo.StartsWith("Set Step"))
                {
                    //_ilogging = SpecflowRunner._iserviceProvider.GetRequiredService<ILogging>();
                    sc["step"] = strStepInfo.Substring(8).TrimStart();
                   
                }
                else
                {
                    _ilogging.Information(sc.ScenarioInfo.Title + "," + sc["step"] + "," + strStepInfo + ",Pass"  + "," + base64);
                }

                //_ilogging.Information(sc.ScenarioInfo.Title + "," + strStepInfo);
                //extentReport.Pass(sc.StepContext.StepInfo.Text, base64);

            }

        }
            [AfterScenario]
            public void AfterScenario()
            {
                //IExtentFeatureReport extentFeatureReport = SpecflowRunner._iserviceProvider.GetRequiredService<IExtentFeatureReport>();
                //extentFeatureReport.FlushExtent();
                Thread.Sleep(2000);
                //_idriver.CloseBrowser();
            }
        }
    }

