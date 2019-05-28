using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SLTConsumerTicketing.Web.Api.Models;

namespace SLTConsumerTicketing.Web.Api.BL
{
    public class PersonService
    {
        
        public int PostPerson()
        {
            var context = new TicketDbContext();
            var list = context.People.ToList();
            return 1;
        }

        public List<Person> GetPeople()
        {
            var people = new List<Person>();


            for (int i=1; i<10; i++)
            {
                people.Add(new Person
                {
                    Id = i,
                    Email = "abc@email.com",
                    FirstName = "F",
                    LastName = "L",
                });
            }

            return people;
        }
    }
}
