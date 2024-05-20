using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.DIContainer;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Report;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.Runner
{
    [Binding]
    public class SpecflowRunner
    {
       public static IServiceProvider _iserviceProvider;
        public static Logging _iLogging;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _iserviceProvider = CoreContainerConfig.ConfigureService();
            _iserviceProvider.GetRequiredService<IGlobalProperties>();
           
        }

        //[BeforeFeature]
        //public static void BeforeFeature(FeatureContext fc)
        //{
        //    IExtentReport iextentReport = _iserviceProvider.GetRequiredService<IExtentReport>();
        //    iextentReport.CreateFeature(fc.FeatureInfo.Title);
        //    fc["iextentreport"] = iextentReport;
        //}

        //[AfterTestRun]
        //public static void AfterTestRun()
        //{

        //    _iLogging = iLogging;

        //    _iLogging.Close();

        //    string[] fileContents = File.ReadAllLines(System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../").FullName + "\\Log\\Log.txt");

        //    ///string[] fileContents = File.ReadAllLines(System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../").FullName + "\\Log\\Log.txt");

        //    for (var i = 0; i < fileContents.Length; i++)
        //    {
        //        Console.WriteLine($"Line #{i + 1}: ");
        //        Console.WriteLine(fileContents[i]);
        //        Console.WriteLine();
        //    }


        //}


    }
}
