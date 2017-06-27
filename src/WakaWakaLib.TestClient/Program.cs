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

            // Testing 

            var key = "<secret api key>";

            var configFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".wakatime.cfg");

            var ret = new StringBuilder(2083);

            key = NativeMethods.GetPrivateProfileString("settings", "api_key", "", ret, 2083, configFile) > 0
                ? ret.ToString()
                : "";

            var api = new WakaWakaLib.ApiV1(key);

            var me = api.Users.GetCurrent().Value;

            var projects = api.Projects.Get().Value;

        }
    }
}
