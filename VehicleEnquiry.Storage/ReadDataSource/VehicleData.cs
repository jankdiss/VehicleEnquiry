using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEnquiry.Storage.ReadDataSource
{
    public class VehicleData
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Comments { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string ABN { get; set; }
        public string SaleType { get; set; }

        public List<EnquiryData> Enquiries { get; set; }

        public List<VehicleData> GetList()
        {
            return new List<VehicleData>()
            {
                new VehicleData () {
                    Id = 1,
                    Make = "2015",
                    Model = "Volvo V40 T4 Luxury Auto MY16",
                    Comments = "This vehicle also comes with 3 years/45,000kms free scheduled servicing",
                    Email = "sales@dealer.com.au",
                    Price = 45888.50,
                    Type = "POA",
                    ContactName = "",
                    Phone = "",
                    ABN = "83 14 571 673",
                    SaleType = "D"
                },
                new VehicleData () {
                    Id = 2,
                    Make = "2015",
                    Model = "BMW 220i Luxury Line F23 Auto",
                    Comments = "We are BMW, we breathe BMW, deal with who you can trust, professionalism second to none.",
                    Email = "sales@mydealer.com.au",
                    Price = 59000.00,
                    Type = "EGC",
                    ContactName = "",
                    Phone = "",
                    ABN = "83 14 571 600",
                    SaleType = "D"
                },
                new VehicleData () {
                    Id = 3,
                    Make = "2015",
                    Model = "Hyundai i30 Active Auto MY16",
                    Comments = "Dedicated online vehicle specialists who work when your not, Times that are family friendly and that suits YOU,",
                    Email = "sales@nodealer.com.au",
                    Price = 23000.00,
                    Type = "EGC",
                    ContactName = "",
                    Phone = "",
                    ABN = "83 14 571 500",
                    SaleType = "D"
                },
                new VehicleData () {
                    Id = 4,
                    Make = "2005",
                    Model = "Volkswagen Polo 66TSI Trendline",
                    Comments = "Friendly customer service and the right advice ",
                    Email = "sales@gooddealer.com.au",
                    Price = 16000.00,
                    Type = "DAP",
                    ContactName = "",
                    Phone = "",
                    ABN = "83 14 571 400",
                    SaleType = "D"
                },
                new VehicleData () {
                    Id = 5,
                    Make = "2015",
                    Model = "Mazda CX-7 Luxury Auto 4WD MY07",
                    Comments = "2008 MAZDA CX7 LUXURY AUTOMATIC  ALL OUR CARS GO THROUGH A 100 POINT SAFETY",
                    Email = "sales@baddealer.com.au",
                    Price = 45000.00,
                    Type = "DAP",
                    ContactName = "",
                    Phone = "",
                    ABN = "83 14 571 000",
                    SaleType = "D"
                },
                new VehicleData () {
                    Id = 6,
                    Make = "2007",
                    Model = "Toyota Yaris YR Manual",
                    Comments = " It has been certified as roadworthy. This car represents great value at $7,500. ",
                    Email = "Nathan@privatesale.com.au",
                    Price = 7500.00,
                    Type = "POA",
                    ContactName = "Nathan, Pete",
                    Phone = "405785465",
                    ABN = String.Empty,
                    SaleType = "P"
                },
                new VehicleData () {
                    Id = 7,
                    Make = "2010",
                    Model = "Volkswagen Eos 103TDI 1F Auto MY11",
                    Comments = "It has tachometer, sports pedals and LED tail lamps. ",
                    Email = "Suzanne@privatesale.com.au",
                    Price = 10500.00,
                    Type = "EGC",
                    ContactName = "Suzanne, Johne",
                    Phone = "045697544",
                    ABN = String.Empty,
                    SaleType = "P"
                },
                new VehicleData () {
                    Id = 8,
                    Make = "2015",
                    Model = "Toyota Landcruiser Sahara Auto 4x4 MY13",
                    Comments = "FEATURES FOR THE WHOLE FAMILY",
                    Email = "Miguel@privatesale.com.au",
                    Price = 103400.00,
                    Type = "DAP",
                    ContactName = "Miguel, David",
                    Phone = "405733790",
                    ABN = String.Empty,
                    SaleType = "P"
                },
                new VehicleData () {
                    Id = 9,
                    Make = "2009",
                    Model = "Chrysler 300c Auto MY09",
                    Comments = "With 5Th opening bridal door ( extra door on the left side of limo )",
                    Email = "Duane@privatesale.com.au",
                    Price = 83000.00,
                    Type = "EGC",
                    ContactName = "Duane, Rogger",
                    Phone = "0405677493",
                    ABN = String.Empty,
                    SaleType = "P"
                },
                new VehicleData () {
                    Id = 10,
                    Make = "2004",
                    Model = "Mercedes-Benz SL350 Auto MY05",
                    Comments = "This car has remote central locking, leather steering wheel and cruise control. ",
                    Email = "Nathan@privatesale.com.au",
                    Price = 41500.00,
                    Type = "POA",
                    ContactName = "Jeremy, Dein",
                    Phone = "0405577390",
                    ABN = String.Empty,
                    SaleType = "P"
                },


            };
        }
    }

    
}
