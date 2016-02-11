using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEnquiry.Core.DTO;

namespace VehicleEnquiry.Core.IContract
{
    public interface IPresistantStorage
    {
        void AddData(IDTO data);
    }
}
