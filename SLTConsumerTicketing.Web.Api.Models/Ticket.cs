using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SLTConsumerTicketing.Common;

namespace SLTConsumerTicketing.Web.Api.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int AssignedId { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public TicketSeverity Severity { get; set; }
    }
}
