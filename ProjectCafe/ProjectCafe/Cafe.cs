using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class Cafe
    {
        public String Name { get; set; }
        public Address CafeAddress { get; set; }
        public String PhoneNumber { get; set; }
        public Open_Close HoursOfOpenClose { get; set; }
        public string Type { get; set; }
        public string Website { get; set; }
        public String Description { get; set; } //optional
        public int RestrictionAge { get; set; } //optional

        public List<Review> Reviews { get; set; }

        public Cafe(string name, Address cafeAddress, string phoneNumber, Open_Close hoursOfOpenClose, string type, string website, string optionalDescription = "", int optionalRestrictionAge = 0)
        {
            Name = name;
            CafeAddress = cafeAddress;
            PhoneNumber = phoneNumber;
            HoursOfOpenClose = hoursOfOpenClose;
            Type = type;
            Website = website;
            Description = optionalDescription;
            RestrictionAge = optionalRestrictionAge;
            Reviews = new List<Review>();
        }

        public override string ToString()
        {
            return (Name + " " + CafeAddress + " " + PhoneNumber + " " + Type + " " + Website);
        }


    }
}
