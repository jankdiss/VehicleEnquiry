using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleEnquiry.Core.DTO;
using VehicleEnquiry.Web.UI.Utils;

namespace VehicleEnquiry.Web.UI.ViewModel
{
    public class VehicleDetailsViewModel
    {
        public VehicleViewModel Details { get; set; }
        public EnquiryViewModel Enquiry { get; set; }

        public VehicleDetailsViewModel DTOToDetailsViewModel(VehicleDTO dto)
        {
            VehicleDetailsViewModel detailsViewModel = new VehicleDetailsViewModel();
            detailsViewModel.Details = dto.ToViewModel();
            detailsViewModel.Enquiry = new EnquiryViewModel() { VehicleId = dto.Id };
            return detailsViewModel;
        }
    }
}