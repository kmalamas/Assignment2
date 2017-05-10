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
        /// <summary>
        /// Implementation of LookupPersonByEmailAsync method declared in IFullContactApi interface.
        /// Gets an email as input to be used as a filter in the request to the API. 
        /// Returns a async task which will return a FullContactPerson object.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            string url = "v2/person.json?email=";
            url = url + email;
            
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                return parseResponse(responseString);
            }
            return null;
        }

        /// <summary>
        /// parses JSON response using Newtonsoft.JSON package. 
        /// It maps the attributes defined for FullContactPerson in the model
        /// defined in FullContactClientCore class library and returns an FullContactPerson object
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public FullContactPerson parseResponse(string response)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            FullContactPerson person = JsonConvert.DeserializeObject<FullContactPerson>(response, settings);
            return person;

        }
    
   
    }
}
