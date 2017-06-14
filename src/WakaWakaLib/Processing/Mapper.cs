using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WakaWakaLib.Processing
{

    public class Mapper
    {

        public static T FromJson<T>(string json) where T: new()
        {

            var x = new T();

            JsonConvert.PopulateObject(json, x, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new ns()
                }
            });

            return x;

        }

        private class ns : NamingStrategy
        {
            protected override string ResolvePropertyName(string name)
            {
                return string.Join("", name.ToCharArray().Select(o => o.ToString()).Select(o => o == o.ToLower() ? o : "_" + o.ToLower()).ToArray()).Trim('_');
            }
        }

    }

}
