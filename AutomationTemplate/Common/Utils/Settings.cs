using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Common.Utils.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Common.Utils
{
    public class Settings
    {
        private Settings()
        {
        }

        private static volatile Settings _instance;
        private static readonly object Locker = new object();

        public static Settings Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Locker)
                {
                    if (_instance == null)
                        _instance = new Settings();
                }

                return _instance;
            }
        }

        private string GetBrowserType()
        {
            return Config.Instance
                .DriverConfig
                .BrowserType;
        }

        public IWebDriver GetDriver()
        {
            lock (Locker)
            {
                switch (GetBrowserType())
                {
                    case "chrome":
                        {
                            var chromeOptions = new ChromeOptions();

                            if (Config.Instance.DriverConfig.HeadlessViewEnabled)
                            {
                                chromeOptions.AddArgument("headless");
                                chromeOptions.AddArgument("window-size=1920x1200");
                            }

                            var chromeDriverPath = GetChromeDriverPath();

                            var chromeDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(chromeDriverPath));
                            return chromeDriver;
                        }
                    case "firefox":
                        var options = new FirefoxOptions();
                        options.SetPreference("devtools.jsonview.enabled", false);
                        return new FirefoxDriver(options);

                    case "internet explorer":
                        var opt = new InternetExplorerOptions();
                        opt.IgnoreZoomLevel = true;
                        opt.EnableNativeEvents = false;
                        return new InternetExplorerDriver(opt);
                    default:
                        throw new Exception("Unknown browser type!");
                }
            }
        }

        private string GetChromeDriverPath()
        {
        var currentPath =
            new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase))
                .LocalPath;

        var chromeDriverPath = string.Concat(currentPath, "\\drivers");

        return chromeDriverPath;
        }
    }
}