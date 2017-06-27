using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WakaWakaLib.Communication;

namespace WakaWakaLib
{

    public class ApiV1
    {

        public string ApiKey { get; set; }

        private const string baseUrl = @"https://wakatime.com/api/v1/";

        public ApiV1()
        {

        }

        public ApiV1(string apiKey)
        {
            ApiKey = apiKey;
        }

        public V1.Users Users => new V1.Users(this);

        public V1.Projects Projects => new V1.Projects(this);

        internal Response<T> Get<T>(string url) where T: new() => Response<T>.Create(RawRequest.GetAsync(baseUrl + url, ApiKey).Result);

    }

}
