using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SLTConsumerTicketing.Web.Api.Models
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext() : base("TicketDbContext")
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
