using System;
using System.IO;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using Serilog;
using Serilog.Events;

namespace Logger
{
    internal class Program
    {
        //private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //var logger = new LoggerConfiguration()
            //    .WriteTo.Console( restrictedToMinimumLevel: LogEventLevel.Information,
            //    outputTemplate: "[{Timestamp} {Level:u3} {Message} {NewLine}]")
            //    .CreateLogger();

            //logger.Information("Application started");

            //try
            //{
            //    Console.Write("Enter num1: ");
            //    int i = int.Parse(Console.ReadLine());
            //    Console.Write("Enter num2: ");
            //    int j = int.Parse(Console.ReadLine());
            //    int sum = i + j;
            //    Console.WriteLine(sum);
            //}
            //catch (Exception e)
            //{
            //    log.Error(e.StackTrace);
            //}

            var date = DateTime.Now;
            Console.WriteLine(date);
        }

        //private static void ConfigureLogging()
        //{
        //    var repository = LogManager.GetRepository();
        //    var layout = new PatternLayout
        //    {
        //        ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
        //    };
        //    layout.ActivateOptions();

        //    var consoleAppender = new ConsoleAppender
        //    {
        //        Layout = layout,
        //        Threshold = Level.All,
        //    };

        //    var errorFileLogger = new FileAppender
        //    {
        //        File = "C:\\Users\\Amar\\OneDrive\\Desktop\\sql\\Logger.log",
        //        AppendToFile = true,
        //        Layout = layout,
        //        Threshold = Level.Error
        //    };
        //    errorFileLogger.ActivateOptions();

        //    BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        //}

        static void Main()
        {
            var ci = new Program();
        }
    }
}
