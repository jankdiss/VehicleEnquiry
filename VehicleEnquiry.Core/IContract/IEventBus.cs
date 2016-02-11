namespace VehicleEnquiry.Core.IContract
{
    public interface IEventBus
    {
        void Publish<T>(T @event);
    }
}
