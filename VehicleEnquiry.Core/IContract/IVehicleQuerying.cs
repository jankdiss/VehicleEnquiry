using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.DTO;

namespace VehicleEnquiry.Core.IContract
{
    public interface IVehicleQuerying
    {
        /// <summary>
        /// Retrive give list of item <Vehicle> with out filtering.
        /// </summary>
        /// <returns></returns>
        IList<VehicleDTO> Get();

        VehicleDTO Get(int id);
    }
}
