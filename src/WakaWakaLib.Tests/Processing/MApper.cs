using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace WakaWakaLib.Tests.Processing
{

    public class MApper
    {

        [Fact]
        public void t()
        {
            var s = @"{""id"": ""abc"",
                        ""has_premium_features"": false,
                        ""display_name"": ""xxx"",
                        ""full_name"": ""yyy""
                     }";

            var o = WakaWakaLib.Processing.Mapper.FromJson<WakaWakaLib.Models.User>(s);

            o.FullName.ShouldBe("yyy");

        }

    }

}
