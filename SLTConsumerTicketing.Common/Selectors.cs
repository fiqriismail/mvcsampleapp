using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLTConsumerTicketing.Common
{
    public enum PersonType
    {
        Customer = 0,
        Staff = 1
    }

    public enum TicketStatus
    {
        New = 0,
        Active = 1,
        Resolved = 2,
        Closed = 3
    }

    public enum TicketSeverity
    {
        Normal = 0,
        Mild = 1,
        Critical = 2
    }
}
