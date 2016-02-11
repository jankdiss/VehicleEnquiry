using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Events;

namespace VehicleEnquiry.Service.Handlers
{
    public class EnqueryEventHandlerFactory : IEventHandlerFactory
    {

        IEventHandler<IEvent> IEventHandlerFactory.GetHandlers()
        {
            return new EnquiryCreatedEventHandler(_storage);
        }

        IPresistantStorage _storage;

        public EnqueryEventHandlerFactory(IPresistantStorage storage)
        {
            _storage = storage;
        }

        
    }
}
