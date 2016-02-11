using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.IContract;

namespace VehicleEnquiry.Domain.Model
{
    public class Enquiry : IDomain
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
