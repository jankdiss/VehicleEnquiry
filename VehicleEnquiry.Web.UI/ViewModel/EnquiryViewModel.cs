using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleEnquiry.Web.UI.ViewModel
{
    public class EnquiryViewModel
    {
        public int VehicleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}