using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Core.IContract
{
    public interface IEventProvider<T> where T : IEvent
    {
        void LoadsFromHistory(IEnumerable<T> history);
        IEnumerable<T> GetUncommittedChanges();
    }
}
