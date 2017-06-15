using System;

namespace WakaWakaLib.Models
{

    public class User
    {
        
        public string Id { get; set; }
        public bool HasPremiumFeatures { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public bool EmailPublic { get; set; }
        public DateTime IsEmailConfirmed { get; set; }
        public bool PhotoPublic { get; set; }
        public string Timezone { get; set; }
        public DateTime LastHeartbeat { get; set; }
        public string LastPlugin { get; set; }
        public string LastPluginName { get; set; }
        public string LastProject { get; set; }
        public string Plan { get; set; }
        public string Username { get; set; }
        public string Website { get; set; }
        public string HumanReadableWebsite { get; set; }
        public string Location { get; set; }
        public bool LoggedTimePublic { get; set; }
        public bool LanguagesUsedPublic { get; set; }
        public bool IsHireable { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }

}
