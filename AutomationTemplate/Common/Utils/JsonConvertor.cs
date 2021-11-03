using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Common.Utils
{
    internal class JsonConvertor
    {
        private readonly JsonSerializerSettings _jsonSettings;
        private static volatile JsonConvertor _instance;
        private static readonly object Locker = new object();
        public static JsonConvertor Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Locker)
                {
                    if (_instance == null)
                    {
                        _instance = new JsonConvertor();
                    }
                }

                return _instance;
            }
        }
        private JsonConvertor()
        {
            _jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            _jsonSettings.Converters.Add(new StringEnumConverter());
        }

        public T Convert<T>(string jsonString)
        {
            var resultObject = JsonConvert.DeserializeObject<T>(jsonString, _jsonSettings);
            return resultObject;
        }
    }
}