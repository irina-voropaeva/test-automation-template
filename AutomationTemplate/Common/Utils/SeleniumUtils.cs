using System;
using System.IO;
using System.Reflection;
using System.Threading;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Common.Utils
{
    public class SeleniumUtils
    {

        public static readonly SeleniumUtils Instance = new();
        public string ErrorMessage;

        private SeleniumUtils()
        {
        }
        protected readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod()
            ?.DeclaringType);


        public string GetCurrentDirectoryPath()
        {
            var pth = Assembly.GetCallingAssembly().CodeBase;
            var uri = new UriBuilder(pth);
            var UriPath = Uri.UnescapeDataString(uri.Path);
            var getDirectorypth = Path.GetDirectoryName(UriPath);
            var finalpth = getDirectorypth.Substring(0, getDirectorypth.LastIndexOf("bin"));
            string path = finalpth + "Reports";
            Log.Info("Current report directory is " + path);
            return path;
        }
    }

}