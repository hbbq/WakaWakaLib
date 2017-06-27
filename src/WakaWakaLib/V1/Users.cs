using System;
using System.Collections.Generic;
using System.Text;
using WakaWakaLib.Models;
using WakaWakaLib.Communication;

namespace WakaWakaLib.V1
{

    public class Users
    {

        internal ApiV1 Api { get; }

        public Users(ApiV1 api)
        {
            Api = api;
        }

        public Response<User> GetCurrent() => Api.Get<User>("users/current");

    }

}
