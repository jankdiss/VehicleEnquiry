using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleEnquiry.Core.Utils.MetaData;

namespace VehicleEnquiry.Core.DTO
{
    public abstract class VehicleDTO
    {
        private PriceType pricetType;

        protected VehicleDTO(PriceType type)
        {
            pricetType = type;
            SetPriceType();
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Comments { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }

        public bool IsEgcPrice { get; private set; }
        public bool IsDapPrice { get; private set; }

        public List<EnquiryDTO> Enquiries { get; set; }


        private void SetPriceType()
        {
            if (pricetType == PriceType.EGC)
            {
                IsDapPrice = false;
                IsEgcPrice = true;
            }
            if (pricetType == PriceType.DAP)
            {
                IsDapPrice = true;
                IsEgcPrice = false;
            }
            else
            {
                IsDapPrice = false;
                IsEgcPrice = false;
            }
        }
    }
}