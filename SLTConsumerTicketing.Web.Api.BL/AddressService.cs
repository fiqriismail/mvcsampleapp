using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region "Project related usings"
using SLTConsumerTicketing.Web.Api.ViewMappers.Address;
using SLTConsumerTicketing.Web.Api.Models;
#endregion

namespace SLTConsumerTicketing.Web.Api.BL
{
    public class AddressService
    {
        TicketDbContext context = new TicketDbContext();

        public int PostAddress(AddressMapper address)
        {
            var newAddress = new Address();

            if (address.Id != null)
            {
                newAddress = context.Addresses.Find(address.Id);

            }

            newAddress.AddNo = address.AddNo;
            newAddress.City = address.City;
            newAddress.Country = address.Country;
            newAddress.Street = address.Street;

            if (address.Id == null)
                context.Entry(newAddress).State = System.Data.Entity.EntityState.Added;
            else
                context.Entry(newAddress).State = System.Data.Entity.EntityState.Modified;
          
            
            context.SaveChanges();

            return newAddress.Id;

        }

        public List<AddressMapper> GetAllAddresses()
        {
            var addressList = context.Addresses.ToList();

            var addresses = new List<AddressMapper>();

            foreach (var address in addressList)
            {
                addresses.Add(new AddressMapper {
                    Id = address.Id,
                    AddNo = address.AddNo,
                    City = address.City,
                    Country = address.Country,
                    Street = address.Street
                }); 
            }

            return addresses;
            
        }

        public AddressMapper GetAddress(int id)
        {
            var address = new AddressMapper();

            var currentAddress = context.Addresses.Find(id);

            address.AddNo = currentAddress.AddNo;
            address.City = currentAddress.City;
            address.Country = currentAddress.Country;
            address.Id = currentAddress.Id;
            address.Street = currentAddress.Street;

            return address;
        }
    }
}
