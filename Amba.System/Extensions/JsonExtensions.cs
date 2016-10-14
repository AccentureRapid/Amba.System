using Newtonsoft.Json;

namespace Amba.System.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object obj, JsonSerializerSettings settings = null)
        {
            if (settings == null)
                return JsonConvert.SerializeObject(obj, new JsonSerializerSettings());
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings());
        }

        public static T FromJson<T>(this string json, JsonSerializerSettings settings = null)
            where T : class
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}
