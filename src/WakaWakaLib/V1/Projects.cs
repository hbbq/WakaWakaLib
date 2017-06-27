using System;
using System.Collections.Generic;
using System.Text;
using WakaWakaLib.Models;
using WakaWakaLib.Communication;

namespace WakaWakaLib.V1
{

    public class Projects
    {

        internal ApiV1 Api { get; }

        public Projects(ApiV1 api)
        {
            Api = api;
        }

        public Response<List<Project>> Get() => Api.Get<List<Project>>($"users/current/projects");

        public Response<List<Project>> Get(User user) => Api.Get<List<Project>>($"users/{user.Id}/projects");

    }

}
