using System;
using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Domain.Events
{
    [Serializable]
    public class Event : IEvent
    {
        public int Version { get; set; }
        public int AggregateId { get; set; }
        public Guid Id { get; private set; }

       
    }
}
