using System;
using System.Threading.Tasks;
using FullContactClientCore;
using FullContactClientCore.model;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace FullContactClient
{
    public class FullContactAPI : IFullContactApi
    {
        private HttpClient _client;

        public FullContactAPI()
        {
            _client = new HttpClient();
            _client.BaseAddress =new Uri("https://api.fullcontact.com");
            _client.DefaultRequestHeaders.Add("X-FullContact-APIKey", "6e05e594b715e44b");
        }
        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            var url = "v2/person.json?email=";
            url = url + email;
            var JsonResponse = string.Empty;

            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                return parseResponse(responseString);
            }
            return null;
        }
     

        public FullContactPerson parseResponse(string response)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            FullContactPerson person = JsonConvert.DeserializeObject<FullContactPerson>(response, settings);
            return person;

        }
    
   
    }
}
