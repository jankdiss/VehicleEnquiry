using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.Utils;

namespace VehicleEnquiry.Core.IContract
{
    public interface IEventStorage
    {
        void Save(IAggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T : BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
