using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("Users.txt");
            List<User> Users = new List<User>();
            String[] open = {
                                "7:05",
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
            cafe1.AddNewReview(new Review(user11, DateTime.Parse("10/01/1987"), "BAD!", 2));

            cafe1.PrintAllReviews();
            cafe1.PrintAverageRate();
            cafe1.PrintTimeTable();

            user1.SaveCafe(cafe1);
            user1.SaveCafe(cafe11);
            user1.SaveCafe(cafe10);


            //user1.PrintFavoriteCafes();

            List<Cafe> cafes = new List<Cafe>();
            cafes.Add(cafe1);
            cafes.Add(cafe2);
            cafes.Add(cafe3);
            cafes.Add(cafe10);
            cafes.Add(cafe11);
            cafes.Sort();
            for (int i = 0; i < cafes.Count; i++)
            {
                Console.WriteLine(cafes[i]);
            }
            //string line;
            //try {
            //    while ((line=reader.ReadLine())!= null)
            //    {
            //        String[] info = line.Split(' ');
            //        Users.Add(new User(info[0],info[1],Convert.ToInt32(info[2]),info[3]));
            //    }
            //}
            //    catch{

            //    }
            while (true)
            {
                Console.WriteLine("1.Create new User");
                Console.WriteLine("2.Create new Cafe");
                Console.WriteLine("3.Show list of Cafes");
                Console.WriteLine("4.Show list of Users");
                String l = Console.ReadLine();
                switch (l)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Enter User's Name");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Enter User's Surname");
                            string userSurname = Console.ReadLine();
                            Console.WriteLine("Enter User's Age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter User's Mail");
                            string userMail = Console.ReadLine();
                            try
                            {
                                Users.Add(new User(userName, userSurname, age, userMail));
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error,Try again");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Cafe's Name");
                        string cafeName = Console.ReadLine();
                        Console.WriteLine("Enter street name");
                        string streetName = Console.ReadLine();
                        Console.WriteLine("Enter street num");
                        string streetNum = Console.ReadLine();
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter city");
                        string country = Console.ReadLine();
                        Console.WriteLine("Enter latitude");
                        double latitude = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter longitude");
                        double longitude = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter phone number");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Hours of opening (in one line, 23:59 format)");
                        String[] opentime = new String[7];
                        
                            opentime = Console.ReadLine().Split(' ');
                        
                        Console.WriteLine("Enter Hours of closeing (in one line, 23:59 format)");
                        String[] closetime = new String[7];
                        
                            closetime = Console.ReadLine().Split(' ');
                        
                        Console.WriteLine("Enter type(cafe, bar...)");
                        string type = Console.ReadLine();
                         Console.WriteLine("Enter web site");
                        string webSite = Console.ReadLine();
                        Console.WriteLine("Write description");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter Restriction Age");
                        int Restrictionage= Convert.ToInt32(Console.ReadLine());
                        cafes.Add(new Cafe(cafeName,new Address(streetName,streetNum,city,country,latitude,longitude),phoneNumber,new Open_Close(open,close),type,webSite,description,Restrictionage));
                        break;
                    case "3":
                        for (int i = 0; i < cafes.Count; i++)
                        {
                            Console.Write(i+1);
                            Console.WriteLine(cafes[i]);
                        }
                        Console.WriteLine("Choose cafe");
                        string c = Console.ReadLine();
                        Console.WriteLine("1.Show nearby cafes");
                        Console.WriteLine("2.Show Reviewes");
                        Console.WriteLine("3.Print Average rate");
                        string k=Console.ReadLine();
                        switch (k)
                        {
                            case "1":
                                cafes[Convert.ToInt32(c)-1].Nearby(cafes);
                                break;
                            case "2":
                                cafes[Convert.ToInt32(c) - 1].PrintAllReviews();
                                break;
                            case "3":
                                cafes[Convert.ToInt32(c) - 1].PrintAverageRate();
                                break;
                        }

                        break;
                }

            }

        }
        public Cafe SearchByName(String Name, List<Cafe> Cafes)
        {
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Name)
                {
                    return Cafes[i];
                }
            }
            return null;
        }
    }
}
