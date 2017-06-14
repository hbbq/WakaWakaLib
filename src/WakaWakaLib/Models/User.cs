using System;
using System.Collections.Generic;
using System.Text;

namespace WakaWakaLib.Models
{

    public class User
    {

        public string Id { get; set; }
        public bool HasPremiumFeatures { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

    }

}
