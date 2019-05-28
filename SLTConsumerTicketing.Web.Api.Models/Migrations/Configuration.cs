namespace SLTConsumerTicketing.Web.Api.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SLTConsumerTicketing.Web.Api.Models.TicketDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SLTConsumerTicketing.Web.Api.Models.TicketDbContext";
        }

        protected override void Seed(SLTConsumerTicketing.Web.Api.Models.TicketDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Addresses.AddOrUpdate(
                new Address
                {
                    Id = 1,
                    AddNo = "25",
                    City = "Colombo",
                    Country = "Sri Lanka",
                    Street = "Street"
                });

            context.People.AddOrUpdate(new Person
            {
                Id = 1,
                DepartmentId = 1,
                Email = "abc@email.com",
                EmployeeId = 1000,
                FirstName = "Saman",
                LastName = "Silva",
                IsCustomerVisible = true,
                NID = "11111111",
                PersonType = Common.PersonType.Customer,
                AddressId = 1
            });
        }
    }
}
