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

            var r = WakaWakaLib.Communication.Request.GetAsync(@"https://wakatime.com/api/v1/users/current");
            var rr = r.Result;
            var rrr = WakaWakaLib.Communication.WrappedResponse<Models.User>.Create(rr);

        }
    }
}
