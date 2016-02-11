using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleEnquiry.Core.Utils.MetaData;

namespace VehicleEnquiry.Core.DTO
{
    public class PrivateVehicleDTO : VehicleDTO
    {
        public PrivateVehicleDTO(PriceType type) : base(type)
        {

        }
        public string ContactName { get; set; }
        public string Phone { get; set; }
    }
}
