using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using SLTConsumerTicketing.Common;

namespace SLTConsumerTicketing.Web.Api.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }
        [StringLength(150)]
        public string LastName { get; set; }
        public string NID { get; set; }
        public string Email { get; set; }
        public PersonType PersonType { get; set; }
        public bool IsCustomerVisible { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public int AddressId { get; set; }

    }
}
