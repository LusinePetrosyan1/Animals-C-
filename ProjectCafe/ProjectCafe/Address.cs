using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace ProjectCafe
{
    class Address
    {
        public String Street { get; set; }
        public String StreetNum { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public GeoCoordinate Location { get; set; }
        public Address(String street, String streetNum, String city, String country, double latitude, double longitude)
        {
            Street = street;
            StreetNum = streetNum;
            City = city;
            Country = country;
            Location = new GeoCoordinate(latitude, longitude);
        }
        public override string ToString()
        {
            return (Street + " " + StreetNum + " " + City + " " + Country);
        }
    }
}