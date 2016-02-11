using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Core.IContract
{
    public interface IEvent
    {
        Guid Id { get; }
        int Version { get; set; }
        int AggregateId { get; set; }
    }
}
