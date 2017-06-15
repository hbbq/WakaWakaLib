using System;

namespace WakaWakaLib.Models
{

    public class UserAgent
    {

        public string Id { get; set; }
        public string Value { get; set; }
        public string Editor { get; set; }
        public string Version { get; set; }
        public string OS { get; set; }
        public DateTime LastSeen{ get; set; }
        public DateTime CreatedAt { get; set; }

    }

}
