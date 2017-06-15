using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace WakaWakaLib.Processing
{

    public class Mapper
    {

        public static T FromJson<T>(string json) where T: new()
        {

            var j = JObject.Parse(json);

            var obj = JsonConvert.DeserializeObject<T>(j["data"].ToString(), new JsonSerializerSettings
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
