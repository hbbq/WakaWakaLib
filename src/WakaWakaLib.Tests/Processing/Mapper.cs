using System;
using Xunit;
using Shouldly;
using System.Collections.Generic;

namespace WakaWakaLib.Tests.Processing
{

    public class Mapper
    {

        [Fact]
        public void FromJson_User()
        {

            var s = Properties.Resources.UserDataJson;

            var user = WakaWakaLib.Processing.Mapper.FromJson<Models.User>(s);

            user.ShouldNotBeNull();
                        
            user.CreatedAt.ShouldBe(new DateTime(2001, 1, 1));
            user.DisplayName.ShouldBe("display name");
            user.Email.ShouldBe("email");
            user.EmailPublic.ShouldBe(true);
            user.FullName.ShouldBe("full name");
            user.HasPremiumFeatures.ShouldBe(true);
            user.HumanReadableWebsite.ShouldBe("human readable website");
            user.Id.ShouldBe("id");
            user.IsEmailConfirmed.ShouldBe(new DateTime(2001, 1, 1));
            user.IsHireable.ShouldBe(true);
            user.LanguagesUsedPublic.ShouldBe(true);
            user.LastHeartbeat.ShouldBe(new DateTime(2001, 1, 1));
            user.LastPlugin.ShouldBe("last plugin");
            user.LastPluginName.ShouldBe("last plugin name");
            user.LastProject.ShouldBe("last project");
            user.Location.ShouldBe("location");
            user.LoggedTimePublic.ShouldBe(true);
            user.ModifiedAt.ShouldBe(new DateTime(2001, 1, 1));
            user.Photo.ShouldBe("photo");
            user.PhotoPublic.ShouldBe(true);
            user.Plan.ShouldBe("plan");
            user.Timezone.ShouldBe("timezone");
            user.Username.ShouldBeNull();
            user.Website.ShouldBe("website");
            
        }

        [Fact]
        public void FromJson_UserAgent()
        {

            var s = Properties.Resources.UserAgentDataJson;

            var userAgent = WakaWakaLib.Processing.Mapper.FromJson<Models.UserAgent>(s);

            userAgent.ShouldNotBeNull();

            userAgent.CreatedAt.ShouldBe(new DateTime(2001, 1, 1));
            userAgent.Editor.ShouldBe("editor");
            userAgent.Id.ShouldBe("id");
            userAgent.LastSeen.ShouldBe(new DateTime(2001, 1, 1));
            userAgent.OS.ShouldBe("os");
            userAgent.Value.ShouldBe("value");
            userAgent.Version.ShouldBe("version");

        }

        [Fact]
        public void FromJson_UserAgentList()
        {

            var s = Properties.Resources.UserAgentListDataJson;

            var userAgents = WakaWakaLib.Processing.Mapper.FromJson<List<Models.UserAgent>>(s);

            userAgents.ShouldNotBeNull();

            userAgents.Count.ShouldBe(2);

            userAgents[0].CreatedAt.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[0].Editor.ShouldBe("editor");
            userAgents[0].Id.ShouldBe("id");
            userAgents[0].LastSeen.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[0].OS.ShouldBe("os");
            userAgents[0].Value.ShouldBe("value");
            userAgents[0].Version.ShouldBe("version");

            userAgents[1].CreatedAt.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[1].Editor.ShouldBe("editor2");
            userAgents[1].Id.ShouldBe("id2");
            userAgents[1].LastSeen.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[1].OS.ShouldBe("os2");
            userAgents[1].Value.ShouldBe("value2");
            userAgents[1].Version.ShouldBe("version2");

        }


        [Fact]
        public void FromJson_UserAgentList_FromSingle()
        {

            var s = Properties.Resources.UserAgentDataJson;

            var userAgents = WakaWakaLib.Processing.Mapper.FromJson<List<Models.UserAgent>>(s);

            userAgents.ShouldNotBeNull();

            userAgents.Count.ShouldBe(1);

            userAgents[0].CreatedAt.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[0].Editor.ShouldBe("editor");
            userAgents[0].Id.ShouldBe("id");
            userAgents[0].LastSeen.ShouldBe(new DateTime(2001, 1, 1));
            userAgents[0].OS.ShouldBe("os");
            userAgents[0].Value.ShouldBe("value");
            userAgents[0].Version.ShouldBe("version");

        }

    }
    
}
