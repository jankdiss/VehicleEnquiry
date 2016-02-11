using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.Exceptions;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Domain.Events;

namespace VehicleEnquiry.Domain.Repository
{
    public class EnquiryRepository: AggregateRoot, IRepository
    {
        private readonly IEventStorage _storage;
        private static object _lockStorage = new object();

        public EnquiryRepository(IEventStorage storage)
        {
            _storage = storage;
        }

        public void Save(IAggregateRoot aggregate, int expectedVersion)
        {
            lock (_lockStorage)
            {
                _storage.Save(aggregate);
            }
        }
        
    }
}
