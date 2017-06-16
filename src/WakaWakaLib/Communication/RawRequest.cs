using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WakaWakaLib.Communication
{

    public class RawRequest
    {

        public static async Task<RawResponse> GetAsync(string url, string apiKey = null)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    
                    if(apiKey != null)
                    {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                            "Basic", 
                            Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey))
                        );
                    }
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
