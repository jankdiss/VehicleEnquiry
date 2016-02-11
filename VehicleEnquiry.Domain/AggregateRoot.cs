using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Core.Utils;
using VehicleEnquiry.Domain.Events;

namespace VehicleEnquiry.Domain
{
    public class AggregateRoot: IAggregateRoot,IEventProvider<IEvent>
    {
        private readonly List<Event> _changes;

        public int Id { get;  set; }
        public int Version { get;  set; }
        public int EventVersion { get;  set; }

        protected AggregateRoot()
        {
            _changes = new List<Event>();
        }

        public void MarkChangesAsCommitted()
        {
            _changes.Clear();
        }

        public void LoadsFromHistory(IEnumerable<IEvent> history)
        {
            foreach (var e in history)
            {
                ApplyChange((Event)e, false);
            }
            Version = history.Last().Version;
            EventVersion = Version;
        }

        protected void ApplyChange(Event @event)
        {
            ApplyChange(@event, true);
        }

        private void ApplyChange(Event @event, bool isNew)
        {
            dynamic d = this;

            d.Handle(Converter.ChangeTo(@event, @event.GetType()));
            if (isNew)
            {
                _changes.Add(@event);
            }
        }

        public IEnumerable<IEvent> GetUncommittedChanges()
        {
            return _changes;
        }

      
    }
}
