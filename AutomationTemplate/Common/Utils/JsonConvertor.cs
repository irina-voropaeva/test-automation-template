using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Common.Utils
{
    internal class JsonConvertor
    {
        private readonly JsonSerializerSettings JsonSettings;
        private static volatile JsonConvertor _instance;
        private static readonly object _locker = new object();
        public static JsonConvertor Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_locker)
                {
                    if (_instance == null)
                        _instance = new JsonConvertor();
                }

                return _instance;
            }
        }
        private JsonConvertor()
        {
            JsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            JsonSettings.Converters.Add(new StringEnumConverter());
        }

        public T Convert<T>(string jsonString)
        {
            var resultObject = JsonConvert.DeserializeObject<T>(jsonString, JsonSettings);
            return resultObject;
        }
    }
}