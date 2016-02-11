using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Events;
using VehicleEnquiry.Domain.Model;

namespace VehicleEnquiry.Service.Handlers
{
    public class EnquiryCreatedEventHandler : IEventHandler<IEvent>
    {

        private readonly IPresistantStorage _storage;

        public EnquiryCreatedEventHandler(IPresistantStorage storage)
        {
            _storage = storage;
        }

        public void Handle(IEvent basehandle)
        {
            var handle = (EnqueryCreatedEvent)basehandle;
            var item = new EnquiryDTO()
            {
                Id = handle.Id,
                Name = handle.Name,
                Email = handle.Email,
                Comments = handle.Comment,
                CreateAt = handle.CreateAt,
                VehicleId = handle.AggregateId
            };

            _storage.AddData(item);
        }
    }
}
