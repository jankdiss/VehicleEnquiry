using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleEnquiry.Core.DTO;

namespace VehicleEnquiry.Web.UI.ViewModel
{
    public class VehicleViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Comments { get; set; }
        public string Email { get; set; }
        public string Price { get; set; }
        public string PriceLabel { get; set; }
        public string SellerInformation { get; set; }

        public virtual VehicleViewModel DTOToViewModel(VehicleDTO dto)
        {
            var viewModel = new VehicleViewModel()
            {
                Id = dto.Id,
                Title = dto.Make + " " + dto.Model,
                Make = dto.Make,
                Model = dto.Model,
                Comments = dto.Comments,
                Email = dto.Email,
                Price = dto.Price.ToString("#,##0.00")
            };

            if (dto.IsDapPrice)
                viewModel.PriceLabel = "Drive Away";
            else if (dto.IsEgcPrice)
                viewModel.PriceLabel = "Excl. Govt. Charges";
            else
                viewModel.PriceLabel = "";

            if(dto.GetType() == typeof(PrivateVehicleDTO))
            {
                var privateVehicle = ((PrivateVehicleDTO)dto);
                viewModel.SellerInformation = String.Format("Name:{0} - Phone: {1}",privateVehicle.ContactName,privateVehicle.Phone);
            }
            else
            {
                var dealersVehicle = ((DealersVehicleDTO)dto);
                viewModel.SellerInformation = String.Format("ABN:{0} ", dealersVehicle.ABN);
            }
            return viewModel;
        }


    }
}