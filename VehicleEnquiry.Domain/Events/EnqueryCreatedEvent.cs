using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Domain.Events
{
    public class EnqueryCreatedEvent : Event
    {
        public Guid EnqueryId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CreateAt { get; set; }

        public EnqueryCreatedEvent(
            int vehicleId,
            Guid enqueryId,
            string name,
            string email,
            string comment,
            DateTime createAt
            )
        {
            AggregateId = vehicleId;
            EnqueryId = enqueryId;
            Name = name;
            Email = email;
            Comment = comment;
            CreateAt = createAt;
        }
    }
}
