using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SLTConsumerTicketing.Web.Api.ViewMappers.Address;
using SLTConsumerTicketing.Web.Api.BL;

namespace SLTConsumerTicketing.Web.Api.Controllers
{
    public class AddressController : ApiController
    {
        AddressService addressService = new AddressService();

        [HttpPost]
        public IHttpActionResult PostAddress(AddressMapper address)
        {
            var id = addressService.PostAddress(address);
            return Ok(id);
        }
    }
}
