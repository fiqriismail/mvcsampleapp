using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SLTConsumerTicketing.Web.Api.ViewMappers.Address
{
    public class AddressMapper
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
        [JsonProperty(PropertyName = "addNo")]
        public string AddNo { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
