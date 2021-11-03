using System;
using System.IO;
using System.Reflection;

namespace Common.Utils.Configuration
{
    public class Config
    {
        private static volatile string _configFileName = "\\config.json";

        private static volatile string _currentPath;
        private static volatile Config _instance;
        private static readonly object Locker = new object();



        public static Config Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Locker)
                {
                    if (_instance != null) return _instance;

                        _configFileName = "\\config.json";
                        var configFile = CurrentPath + _configFileName;
                    var configJson = File.ReadAllText(configFile);
                    _instance = JsonConvertor.Instance.Convert<Config>(configJson);
                }

                return _instance;
            }
        }

        public static string CurrentPath => _currentPath ?? (_currentPath =
                                                new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase))
                                                    .LocalPath);

        public string BaseUrl { get; set; }

        public DriverConfig DriverConfig { get; set; }
    }
}