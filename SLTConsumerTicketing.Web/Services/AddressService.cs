using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

using SLTConsumerTicketing.Web.Models;


namespace SLTConsumerTicketing.Web.Services
{
    public class AddressService
    {
        public string ApiUrl { get; set; }

        public async Task<List<AddressViewMapper>> GetAllAddresses()
        {
            List<AddressViewMapper> addressList = new List<AddressViewMapper>();

            using (var client = new HttpClient())
            {
                // Create endpoint to get all addresses
                var endPoint = $"{ApiUrl}/api/Address/GetAddresses";
                var response = await client.GetAsync(endPoint);
                var data = await response.Content.ReadAsStringAsync();

                addressList = JsonConvert.DeserializeObject<List<AddressViewMapper>>(data);
            }

            return addressList;
        }

        public async Task<AddressViewMapper> GetAddress(int id)
        {
            AddressViewMapper address = null;

            using (var client = new HttpClient())
            {
                // Create endpoint to get all addresses
                var endPoint = $"{ApiUrl}/api/Address/GetAddress/{id}";
                var response = await client.GetAsync(endPoint);

                var data = await response.Content.ReadAsStringAsync();

                address = JsonConvert.DeserializeObject<AddressViewMapper>(data);

            }

            return address;

        }

        public async Task<int> PostAddress(AddressViewMapper address)
        {
            var returnedId = 0;

            using (var client = new HttpClient())
            {
                // Create endpoint to get all addresses
                var endPoint = $"{ApiUrl}/api/Address/PostAddress";
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                List<KeyValuePair<string, string>> formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("id", ""));
                formData.Add(new KeyValuePair<string, string>("addNo", address.AddNo));
                formData.Add(new KeyValuePair<string, string>("street", address.Street));
                formData.Add(new KeyValuePair<string, string>("city", address.City));
                formData.Add(new KeyValuePair<string, string>("country", address.Country));

                try
                {
                    var response = await client.PostAsync(endPoint, new FormUrlEncodedContent(formData));
                    var result = await response.Content.ReadAsStringAsync();

                    returnedId = int.Parse(result);
                } catch (Exception ex)
                {
                    //TODO
                }
            }

            return returnedId;
        }
    }
}