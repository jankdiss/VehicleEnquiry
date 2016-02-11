using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Core.IContract
{
    public interface IAggregateRoot
    {
        int Id { get;  set; }
        int Version { get; set; }
        int EventVersion { get; set; }

        IEnumerable<IEvent> GetUncommittedChanges();
    }
}
