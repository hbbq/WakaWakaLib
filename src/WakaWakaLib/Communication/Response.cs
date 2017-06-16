using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace WakaWakaLib.Communication
{

    public class Response<T> where T: new()
    {

        public bool Success { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }

        public static Response<T> Create(RawResponse response)
        {
            if (response.Success)
            {
                return new Response<T>
                {
                    Success = true,
                    Value = Mapper.FromJson<T>(response.Content),
                    Error = null,
                };
            }
            else
            {
                var j = JObject.Parse(response.Content);
                var j2 = j["error"].ToString();

                return new Response<T>
                {
                    Success = false,
                    Value = default(T),
                    Error = j2
                };

            }
        }

    }

}
