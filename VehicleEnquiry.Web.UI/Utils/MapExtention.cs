using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Web.UI.ViewModel;

namespace VehicleEnquiry.Web.UI.Utils
{
    public static class MapExtention
    {
        public static List<VehicleViewModel> ToViewModel(this IList<VehicleDTO> dto)
        {
            List<VehicleViewModel> _list = new List<VehicleViewModel>();
            if (dto.Count() > 0)
                dto.ToList().ForEach(item => _list.Add(item.ToViewModel()));
            return _list;
        }

        public static VehicleViewModel ToViewModel(this VehicleDTO dto)
        {
            return new VehicleViewModel().DTOToViewModel(dto);
        }

        public static VehicleDetailsViewModel ToDetailsViewModel(this VehicleDTO dto)
        {
            return new VehicleDetailsViewModel().DTOToDetailsViewModel(dto);
        }

        
    }
}