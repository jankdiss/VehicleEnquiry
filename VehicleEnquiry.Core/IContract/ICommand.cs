using System;

namespace VehicleEnquiry.Core.IContract
{
    public interface ICommand 
    {
        Guid Id { get; }
    }
}
