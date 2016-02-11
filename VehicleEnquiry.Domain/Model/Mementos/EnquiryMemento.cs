using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.Utils;

namespace VehicleEnquiry.Domain.Model.Mementos
{

    public class EnquiryMemento : BaseMemento
    {

        public string Name { get; internal set; }
        public string Email { get; internal set; }
        public string Comment { get; internal set; }
        public int VehicleId { get; internal set; }
        public DateTime CreateAt { get; internal set; }

        public EnquiryMemento(
            Guid id, 
            string name, 
            string email, 
            string comment, 
            DateTime createAt,
            int vehicleId)
        {
            Id = id;
            Name = name;
            Email = email;
            Comment = comment;
            CreateAt = createAt;
            VehicleId = vehicleId;
        }
    }
}
