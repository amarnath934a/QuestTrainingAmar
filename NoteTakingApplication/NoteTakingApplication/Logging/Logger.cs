using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingConsoleApplication.Logging
{
    public static class Logger
    {
        //private static readonly string logFilePath = @"C:\Users\Amar\OneDrive\Desktop\sql\NoteTakingApplication\New Text Document.txt";
        private static readonly string logFilePath = @"C:\Users\Amar\source\repos\NoteTakingConsoleApplication\NoteTakingConsoleApplication\TextFile1.txt";
        public static void Log(string message)
        {
            using (var writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        public static void LogError(Exception ex)
        {
            Log($"Error occured: {ex.Message}");
        }
    }
}
