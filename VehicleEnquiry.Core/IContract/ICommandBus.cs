using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Core.IContract
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
    }
}
