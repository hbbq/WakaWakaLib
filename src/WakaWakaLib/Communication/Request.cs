using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WakaWakaLib.Communication
{

    public class Request
    {

        public static async Task<RawResponse> GetAsync(string url)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var message = await client.GetAsync(url);
                    var content = await message.Content.ReadAsStringAsync();
                    var response = new RawResponse
                    {
                        Success = message.IsSuccessStatusCode,
                        Code = (int)message.StatusCode,
                        Content = content
                    };
                    return response;
                }
            }
            catch(Exception e)
            {
                return new RawResponse
                {
                    Success = false,
                };
            }

        }

    }

}
