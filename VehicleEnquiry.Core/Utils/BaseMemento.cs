using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Core.Utils
{
    public class BaseMemento
    {
        public Guid Id { get;  set; }
        public int Version { get; set; }
    }
}
