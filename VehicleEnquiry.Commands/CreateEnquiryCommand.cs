using System;
using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Commands
{
    public class CreateEnquiryCommand : Command
    {

        public string Name { get; internal set; }
        public string Email { get; internal set; }
        public string Comment { get; internal set; }
        public DateTime CreatedAt { get; internal set; }


        public CreateEnquiryCommand(
            Guid aggregateId,
            int vehicleId,
            string name,
            string email,
            string comment, 
            DateTime createdAt)
            : base(aggregateId, vehicleId)
        {
            Name = name;
            Email = email;
            Comment = comment;
            CreatedAt = createdAt;
        }
    }
}
