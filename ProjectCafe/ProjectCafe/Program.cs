using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] open = {
                                "7:30",
                                "7:30",
                                "7:30",
                                "7:30",
                                "7:30",
                                "9:00",
                                "9:30"
                            };
            String[] close = {
                                "22:30",
                                "22:30",
                                "22:30",
                                "22:30",
                                "22:30",
                                "23:00",
                                "23:30"
                            };
            Open_Close hours1 = new Open_Close(open, close);

            Cafe cafe1 = new Cafe("Jose", new Address("Aram", "28", "Yerevan", "Armenia", 40.17506970913358, 44.519750475883484), "091540020", hours1, "Restaurant", "jose.am", optionalRestrictionAge: 18);
            Cafe cafe2 = new Cafe("Aeon", new Address("Teryan", "3", "Yerevan", "Armenia", 40.18178325626785, 44.5125675201416), "010538766", hours1, "Cafe", "aeonyerevan.com");
            Cafe cafe3 = new Cafe("Havana", new Address("Leningradyan", "1/6", "Yerevan", "Armenia", 40.19033280000001, 44.48103570000001), "010380606", hours1, "Restaurant", "havana.am", optionalRestrictionAge: 14);
            Cafe cafe10 = new Cafe("Cinnabon", new Address("Northern ave", "8", "Yerevan", "Armenia", 40.182053751571125, 44.51447993516922), "010433535", new Open_Close(open, close), "cafe", "cinnabon.am", optionalRestrictionAge: 18);
            Cafe cafe11 = new Cafe("La Piazza", new Address("Northern ave", "10", "Yerevan", "Armenia", 40.18187751990506, 44.514833986759186), "010434343", new Open_Close(open, close), "cafe", "lapizza.am", optionalRestrictionAge: 15);
            User user1 = new User("Lusine", "Petrosyan", 18, "lusinecfc1@gmail.com");
            User user2 = new User("Khachatur", "Khechoyan", 5, "khachatur1998@mail.ru");
            User user3 = new User("Ragnar", "Lothbrock", 30, "RagnarL@mail.ru");
            User user4 = new User("Crocodile", "Gena", 14, "Gena2003@mail.ru");
            User user5 = new User("Holden", "Caulfield", 16, "TheCatcher@gmail.com");
            User user10 = new User("Bob", "Marley", 98, "BobMarley@gmail.com");
            User user11 = new User("Emin", "Davidov", 40, "EminDav@gmail.com");
            User user12 = new User("Lusine", "Petrosyan", 4, "lusinecfc1@gmail.com");
            User user13 = new User("Tigran", "Jamkochyan", 43, "tikorabiz@gmail.com");
            User user14 = new User("Jor", "Dilbaryan", 56, "jorikjorik@gmail.com");

            cafe1.Visit(user13);
            cafe11.Visit(user3);
            cafe11.Visit(user1);
            cafe10.Visit(user2);

            cafe1.AddNewReview(new Review(user1, DateTime.Parse("10 / 01 / 1999"), "Very Good!", 5));
            cafe1.AddNewReview(new Review(user2, DateTime.Parse("10 / 01 / 1999"), "Normal!", 4));
            cafe1.AddNewReview(new Review(user12, DateTime.Parse("10/01/1987"), "BAD!", 2));

            cafe1.PrintAllReviews();
            cafe1.PrintAverageRate();

            cafe1.PrintTimeTable();

            user1.SaveCafe(cafe1);
            user1.SaveCafe(cafe11);
            user1.SaveCafe(cafe10);

            user1.PrintFavoriteCafes();
        }
    }
}
