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

            var s = @"{""id"": ""abc"",
                        ""has_premium_features"": false,
                        ""display_name"": ""xxx"",
                        ""full_name"": ""yyy""
                     }";

            var o = WakaWakaLib.Processing.Mapper.FromJson<WakaWakaLib.Models.User>(s);

            var m = o.FullName;

        }
    }
}
