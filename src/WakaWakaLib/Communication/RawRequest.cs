using System;
using System.Collections.Generic;
using System.Net.Http;
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
                using (var client = GetHttpClient(apiKey))
                {                                        
                    //SendAsync?
                    return await WrapResponse(await client.GetAsync(url));
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

        private static HttpClient GetHttpClient(string apiKey = null)
        {
            var client = new HttpClient();
            if (apiKey != null)
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey))
                );
            }
            return client;
        }

        private static async Task<RawResponse> WrapResponse(HttpResponseMessage message)
        {
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

}
