using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Storage.ReadDataSource
{
    public class EnquiryData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public DateTime CreateAt { get; set; }
        public int VehicleId { get; set; }
    }
}
