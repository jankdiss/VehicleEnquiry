using System;
using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Commands
{
    [Serializable]
    public class Command : ICommand
    {
        public Guid Id { get; private set; }
        public int VehicleId { get; private set; }
        public Command(Guid id, int vehicleId)
        {
            Id = id;
            VehicleId = vehicleId;
        }
    }
}
