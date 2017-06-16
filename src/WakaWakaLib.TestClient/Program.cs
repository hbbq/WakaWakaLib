using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WakaWakaLib.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = "<secret api key>";

            var r = WakaWakaLib.Communication.RawRequest.GetAsync(@"https://wakatime.com/api/v1/users/current", key);
            var rr = r.Result;
            var rrr = WakaWakaLib.Communication.Response<Models.User>.Create(rr);

        }
    }
}
