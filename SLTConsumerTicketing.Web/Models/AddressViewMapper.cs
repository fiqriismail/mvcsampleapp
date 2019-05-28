using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SLTConsumerTicketing.Web.Models
{
    public class AddressViewMapper
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "addNo")]
        [Required]
        public string AddNo { get; set; }

        [JsonProperty(PropertyName = "street")]
        [Required]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "city")]
        [Required]
        public string City { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}