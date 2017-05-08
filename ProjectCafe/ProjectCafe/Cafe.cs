using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectCafe
{
    class Cafe : IComparable<Cafe>
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
        public List<User> Visitors { get; set; }

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
            Visitors = new List<User>();
        }

        public override string ToString()
        {
            return (Name + " " + CafeAddress + " " + PhoneNumber + " " + Type + " " + Website);
        }
        public void AddNewReview(Review rev)
        {
            Reviews.Add(rev);
        }

        public void PrintAllReviews()
        {
            Console.WriteLine(this);
            for (int i = 0; i < Reviews.Count; i++)
            {
                Console.WriteLine(Reviews[i]);
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine();
        }
        public void Visit(User user)
        {
            if (user.Age < RestrictionAge)
            {
                Console.WriteLine("Sorry" + " " + user.Name + "!" + " Come " + " " + (RestrictionAge - user.Age) + " " + "years later!");
                Console.WriteLine("_________________________________________________________________");
            }
            else
            {
                Visitors.Add(user);
                Console.WriteLine("Welcome to" + " " + Name + "!" + " " + user);
                Console.WriteLine("_________________________________________________________________");
            }
        }
        public int GetVisitorsCount()
        {
            return Visitors.Count();
        }
        public void PrintTimeTable()
        {
            Console.WriteLine(HoursOfOpenClose);
            Console.WriteLine("_________________________________________________________________");
        }
        public double DistanceFrom(Cafe cafe2)
        {
            return (CafeAddress.Location.GetDistanceTo(cafe2.CafeAddress.Location));
        }
        public void Nearby(List<Cafe> cafes)
        {
            Console.WriteLine(this.Name+"'s" +" "+ "nearby cafes");
            Console.WriteLine();
            foreach (var item in cafes)
            {
                if (DistanceFrom(item) < 1000.0 && DistanceFrom(item) > 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("_________________________________________________________________");
        }
        public void PrintAverageRate()
        {
            Console.WriteLine(this.Name);
            double sum = 0;
            if (Reviews.Count == 0) {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < Reviews.Count; i++)
            {
                sum += Reviews[i].Rate;
            }
            Console.WriteLine((double)((int)(sum / Reviews.Count * 10)) / 10);
            Console.WriteLine("_________________________________________________________________");
        }

        public int CompareTo(Cafe that)
        {
            if (that.GetVisitorsCount() > this.GetVisitorsCount())
            {
                return 1;
            }
            else if (that.GetVisitorsCount() < this.GetVisitorsCount())
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
