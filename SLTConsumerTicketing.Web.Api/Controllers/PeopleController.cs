using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



using SLTConsumerTicketing.Web.Api.BL;

namespace SLTConsumerTicketing.Web.Api.Controllers
{
    public class PeopleController : ApiController
    {
        private PersonService personService = new PersonService();

        [HttpPost]
        public IHttpActionResult PostPerson()
        {
            var id = personService.PostPerson();
            return Ok(id);
        }

        [HttpGet]
        public IHttpActionResult GetPeople()
        {
            var people = personService.GetPeople();
            return Ok(people);
        }


    }
}
