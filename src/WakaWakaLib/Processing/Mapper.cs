using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace WakaWakaLib.Processing
{

    public class Mapper
    {

        public static T FromJson<T>(string json) where T: new()
        {

            var j = JObject.Parse(json);
            var j2 = j["data"].ToString();

            if((new T()) is IEnumerable)
            {
                if (!j2.Trim().StartsWith("["))
                {
                    j2 = $"[{j2}]";
                }
            }

            var obj = JsonConvert.DeserializeObject<T>(j2, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            });

            return obj;

        }
        
    }

}
