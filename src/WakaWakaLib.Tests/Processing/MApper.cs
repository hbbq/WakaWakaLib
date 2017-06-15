using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace WakaWakaLib.Tests.Processing
{

    public class Mapper
    {

        [Fact]
        public void FromJson_User()
        {
            var s = @"{""id"": ""id"",
                        ""has_premium_features"": true,
                        ""display_name"": ""display name"",
                        ""full_name"": ""full name""
                     }";

            var o = WakaWakaLib.Processing.Mapper.FromJson<WakaWakaLib.Models.User>(s);

            o.Id.ShouldBe("id");
            o.HasPremiumFeatures.ShouldBe(true);
            o.DisplayName.ShouldBe("display name");
            o.FullName.ShouldBe("full name");

        }

        [Fact]
        public void PascalCaseToSnakeCase()
        {
            
            var c = new WakaWakaLib.Processing.Mapper.PascalCaseToSnakeCase();
            c.ResolvePropertyName("TestPropName").ShouldBe("test_prop_name");

        }

    }

}
