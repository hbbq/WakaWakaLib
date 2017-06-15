using System;
using Xunit;
using Shouldly;

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
            user.IsEmailConfirmed.ShouldBe(true);
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
            user.Username.ShouldBe("username");
            user.Website.ShouldBe("website");
            
        }

    }
    
}
