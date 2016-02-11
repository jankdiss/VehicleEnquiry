using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleEnquiry.Core.Utils.MetaData;

namespace VehicleEnquiry.Core.DTO
{
    public class DealersVehicleDTO : VehicleDTO
    {
        public DealersVehicleDTO(PriceType type) : base(type)
        {

        }

        public string ABN { get; set; }
    }
}
