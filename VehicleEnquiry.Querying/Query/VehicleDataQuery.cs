using System;
using System.Collections.Generic;
using System.Linq;
using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Storage.ReadDataSource;
using static VehicleEnquiry.Core.Utils.MetaData;

namespace VehicleEnquiry.Querying.Query
{
    public class VehicleDataQuery : IVehicleQuerying
    {
        private static List<VehicleData> dataSource = null;

        public VehicleDataQuery()
        {
            dataSource = new VehicleData().GetList();
        }

        public IList<VehicleDTO> Get()
        {
            var _returnList = new List<VehicleDTO>();
          
            foreach (var item in dataSource)
            {
                _returnList.Add(MapToDTO(item));
            }

            return _returnList;
        }

        public VehicleDTO Get(int id)
        {
            return MapToDTO(dataSource.SingleOrDefault(c => c.Id == id));
        }

        private VehicleDTO MapToDTO(VehicleData data)
        {
            var type = PriceType.POA;
        
            if(data.Type ==  PriceType.EGC.ToString())
            {
                type = PriceType.EGC;
            }
            else if (data.Type == PriceType.DAP.ToString())
            {
                type = PriceType.DAP;
            }

            if (data.SaleType == "D")
            {
                return new DealersVehicleDTO(type)
                {
                    Id = data.Id,
                    Model = data.Model,
                    Make = data.Make,
                    ABN = data.ABN,
                    Comments = data.Comments,
                    Email = data.Email,
                    Price = data.Price
                };
            }
            else
            {
                return new PrivateVehicleDTO(type)
                {
                    Id = data.Id,
                    Model = data.Model,
                    Make = data.Make,
                    ContactName = data.ContactName,
                    Phone = data.Phone,
                    Comments = data.Comments,
                    Email = data.Email,
                    Price = data.Price
                };
            }

        }
    }
}
