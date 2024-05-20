using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Abstraction;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.Report
{
    public class Logging : ILogging
    {
        LoggingLevelSwitch _loggingLevelSwitch;
        IDefaultVariables _idefaultVariables;
        public Logging(IDefaultVariables idefaultVariables)
        {
           // string LogFileName = _idefaultVariables.getLog;
            //fc["LogFileName"] = LogFileName;
            //DefaultVariables defaultVariables = new DefaultVariables();
            _idefaultVariables = idefaultVariables;
            string LogFileName = _idefaultVariables.getLog;
            //File.Delete(LogFileName);
            _loggingLevelSwitch = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);


            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(_loggingLevelSwitch)
                .WriteTo.File(LogFileName, outputTemplate: "{Timestamp:yyyy-MM-dd}, {Timestamp:HH:mm:ss},[{Level:u3}], {Message:lj}{Exception}{NewLine}")
                .Enrich.WithThreadName().CreateLogger();

        }

        public void LogLevel(string level)
        {
            switch (level.ToLower())
            {
                case "error":
                    _loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Error;
                    break;
                case "information":
                    _loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Information;
                    break;
                case "warning":
                    _loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Warning;
                    break;
                default:
                    _loggingLevelSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Debug;
                    break;
            }
        }

        public void Close()
        {
            Log.CloseAndFlush();


        }



        public void Debug(string message)
        {
            Log.Debug(message);
            
            
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Fatal(string message)
        {
            Log.Fatal(message);
        }

        public void Warning(string message)
        {
            Log.Warning(message);
        }

        public void Information(string message)
        {
            Log.Information(message);
        }

    }
}
