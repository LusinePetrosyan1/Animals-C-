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
            List<User> Users = new List<User>();
            List<Cafe> cafes = new List<Cafe>();
            StreamReader reader;
            StreamWriter writer;
            using (reader = new StreamReader("Users.txt"))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] linearr = line.Split(' ');
                    Users.Add(new User(linearr[0], linearr[1], Convert.ToInt32(linearr[2]), linearr[3]));
                }
                reader.Close();
            }
            using (reader = new StreamReader("Cafes.txt"))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] linearr = line.Split(' ');
                    String[] Open = { linearr[8], linearr[9], linearr[10], linearr[11], linearr[12], linearr[13], linearr[14] };
                    String[] Close = { linearr[15], linearr[16], linearr[17], linearr[18], linearr[19], linearr[20], linearr[21] };
                    cafes.Add(new Cafe(linearr[0], new Address(linearr[1], linearr[2], linearr[3], linearr[4], Convert.ToDouble(linearr[5]), Convert.ToDouble(linearr[6])), linearr[7], new Open_Close(Open, Close), linearr[22], linearr[23], linearr[24], Convert.ToInt32(linearr[25])));
                }
                reader.Close();
            }

            while (true)
            {
            z:
                Console.WriteLine("Welcome!");
                Console.WriteLine("Choose what you want to do.");
                Console.WriteLine();
                Console.WriteLine("1.Create new User");
                Console.WriteLine("2.Create new Cafe");
                Console.WriteLine("3.Show list of Cafes");
                Console.WriteLine("4.Show list of Users");
                Console.WriteLine("5.Search Cafe");
                Console.WriteLine();
                String l = Console.ReadLine();
                Console.WriteLine();
                switch (l)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Enter User's Name");
                            string userName = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Surname");
                            string userSurname = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Age");
                            int age;
                            while (true)
                            {
                                try
                                {
                                    age = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid age! Please try again!");
                                    Console.WriteLine();
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Mail");
                            string userMail = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("User have successfully been created!");
                            Console.WriteLine();

                            using (writer = new StreamWriter("Users.txt", true))
                            {
                                writer.Write(userName + " " + userSurname + " " + age + " " + userMail + "\r\n");
                                writer.Flush();
                                writer.Close();
                            }
                            try
                            {
                                Users.Add(new User(userName, userSurname, age, userMail));
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error,Try again");
                            }

                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Cafe's Name");
                        string cafeName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter street name");
                        string streetName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter street num");
                        string streetNum = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter country");
                        string country = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter latitude");
                        double latitude;
                        while (true)
                        {
                            try
                            {
                                latitude = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid latitude! Please try again!");
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter longitude");
                        double longitude;
                        while (true)
                        {
                            try
                            {
                                longitude = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid longitude! Please try again!");
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter phone number");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Hours of opening (in one line, 23:59 format)");
                        String[] opentime = new String[7];

                        opentime = Console.ReadLine().Split(' ');
                        Console.WriteLine();

                        Console.WriteLine("Enter Hours of closing (in one line, 23:59 format)");
                        String[] closetime = new String[7];

                        closetime = Console.ReadLine().Split(' ');
                        Console.WriteLine();
                        Console.WriteLine("Enter type(cafe, bar...)");
                        string type = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter website");
                        string webSite = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Write description");
                        string description = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Enter Restriction Age");
                        int RestrictionAge;
                        while (true)
                        {
                            try
                            {
                                RestrictionAge = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid age! Please try again!");
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Cafe have successfully been created!");
                        Console.WriteLine();
                        cafes.Add(new Cafe(cafeName, new Address(streetName, streetNum, city, country, latitude, longitude), phoneNumber, new Open_Close(opentime, closetime), type, webSite, description, RestrictionAge));
                        using (writer = new StreamWriter("Cafes.txt", true))
                        {
                            writer.Write(cafeName + " " + streetName + " " + streetNum + " " + city + " " + country + " " + latitude + " " + longitude + " " + phoneNumber + " ");
                            for (int i = 0; i < 7; i++)
                            {
                                writer.Write(opentime[i] + " ");
                            }
                            for (int i = 0; i < 7; i++)
                            {
                                writer.Write(closetime[i] + " ");
                            }
                            writer.Write(type + " " + webSite + " " + "." + " " + RestrictionAge + "\r\n");
                            writer.Flush();
                            writer.Close();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Choose cafe");
                        Console.WriteLine();
                        for (int i = 0; i < cafes.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(cafes[i].Name);
                        }
                        Console.WriteLine(cafes.Count + 1 + ".Exit To Main Menu");
                        Console.WriteLine();
                        string c;

                        while (true)
                        {
                            c = Console.ReadLine();
                            try
                            {
                                if (Convert.ToInt32(c) > cafes.Count + 1 || Convert.ToInt32(c) <= 0)
                                {
                                    Console.WriteLine("Error! Invalid number!");
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! Invalid number!");
                            }
                        }
                        if (Convert.ToInt32(c) == (cafes.Count + 1))
                        {
                            goto z;
                        }
                        Console.WriteLine();
                        Console.WriteLine(cafes[int.Parse(c) - 1].ToString());
                        Console.WriteLine();
                        while (true)
                        {
                            Console.WriteLine("1.Show nearby cafes");
                            Console.WriteLine("2.Show Reviews");
                            Console.WriteLine("3.Print Average rate");
                            Console.WriteLine("4.Add Review");
                            Console.WriteLine("5.Visit");
                            Console.WriteLine("6.Print Timetable");
                            Console.WriteLine("7.Distance From");
                            Console.WriteLine("8.Exit to main menu");
                            Console.WriteLine();
                            string k = Console.ReadLine();
                            Console.WriteLine();
                            switch (k)
                            {
                                case "1":
                                    cafes[Convert.ToInt32(c) - 1].Nearby(cafes);
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    cafes[Convert.ToInt32(c) - 1].PrintAllReviews();
                                    break;
                                case "3":
                                    cafes[Convert.ToInt32(c) - 1].PrintAverageRate();
                                    Console.WriteLine();
                                    break;
                                case "4":

                                    for (int i = 0; i < Users.Count; i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        Console.WriteLine(Users[i]);
                                    }
                                    Console.WriteLine();
                                    string q;
                                    while (true)
                                    {
                                        q = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(q) > Users.Count || Convert.ToInt32(q) <= 0)
                                            {
                                                Console.WriteLine("Error! Invalid number!");
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Error! Invalid number!");
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Write Your Oppinion");
                                    Console.WriteLine();
                                    String op = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Write Your Rate (0-5)");
                                    Console.WriteLine();
                                    String ra;
                                    while (true)
                                    {
                                        ra = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(ra) > 5 || Convert.ToInt32(ra) < 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid number! Please try again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                goto gt;
                                        }
                                        catch
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid number! Please try again!");
                                            Console.WriteLine();
                                        }
                                    }
                                gt:
                                    cafes[Convert.ToInt32(c) - 1].AddNewReview(new Review(Users[Convert.ToInt32(q) - 1], DateTime.Now, op, Convert.ToInt32(ra)));
                                    Console.WriteLine();
                                    Console.WriteLine("Thank you for your rate!");
                                    Console.WriteLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Choose User");
                                    Console.WriteLine();
                                    for (int i = 0; i < Users.Count; i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        Console.WriteLine(Users[i]);
                                    }
                                    Console.WriteLine();
                                    string h;
                                    while (true)
                                    {
                                        h = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(h) > Users.Count || Convert.ToInt32(h) <= 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid number! Please Try Again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid number! Please Try Again!");
                                            Console.WriteLine();
                                        }
                                    }
                                    Console.WriteLine();
                                    cafes[int.Parse(c) - 1].Visit(Users[int.Parse(h) - 1]);
                                    Console.WriteLine("Do you want to write review?");
                                    Console.WriteLine();
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    Console.WriteLine();
                                    string yesorno = Console.ReadLine();
                                    Console.WriteLine();
                                    switch (yesorno)
                                    {
                                        case "1":
                                            Console.WriteLine("Write Your Oppinion");
                                            Console.WriteLine();
                                            String opin = Console.ReadLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Write Your Rate (0-5)");
                                            Console.WriteLine();
                                            String rt;
                                            while (true)
                                            {
                                                rt = Console.ReadLine();
                                                try
                                                {
                                                    if (Convert.ToInt32(rt) > 5 || Convert.ToInt32(rt) < 0)
                                                    {
                                                        Console.WriteLine("Invalid number! Please try again!");
                                                    }
                                                    else
                                                        goto gtt;
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Invalid number! Please try again!");
                                                }
                                            }
                                        gtt:
                                            cafes[Convert.ToInt32(c) - 1].AddNewReview(new Review(Users[Convert.ToInt32(h) - 1], DateTime.Now, opin, Convert.ToInt32(rt)));
                                            Console.WriteLine("Thank you for your rate!");
                                            break;
                                        case "2":
                                            Console.WriteLine("Thank you for your visit!");
                                            break;
                                        default:
                                            Console.WriteLine("Invalid number! Please try again!");
                                            break;
                                    }
                                    break;
                                case "6":
                                    cafes[int.Parse(c) - 1].PrintTimeTable();
                                    break;
                                case "7":
                                    Console.WriteLine("Choose Cafe");
                                    for (int i = 0; i < cafes.Count; i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        Console.WriteLine(cafes[i].Name);
                                    }
                                    Console.WriteLine();
                                    string cnum;
                                    while (true)
                                    {
                                        cnum = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(cnum) > cafes.Count || Convert.ToInt32(cnum) <= 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid number! Please Try Again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid number! Please Try Again!");
                                            Console.WriteLine();
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine(cafes[int.Parse(c) - 1].DistanceFrom(cafes[int.Parse(cnum) - 1]));
                                    Console.WriteLine();
                                    break;

                                case "8":
                                    goto x;
                                default:
                                    Console.WriteLine("Invalid number!Please try again!");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                    x:
                        break;
                    case "4":
                        for (int i = 0; i < Users.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(Users[i]);
                        }
                        Console.WriteLine(Users.Count + 1 + "." + "Exit To Main Menu");
                        string u;
                        while (true)
                        {
                            u = Console.ReadLine();
                            try
                            {
                                if (Convert.ToInt32(u) > Users.Count + 1 || Convert.ToInt32(u) <= 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid number! Please Try Again!");
                                    Console.WriteLine();
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid number! Please Try Again");
                                Console.WriteLine();
                            }
                        }
                        if (Convert.ToInt32(u) == (Users.Count + 1))
                        {
                            goto z;
                        }
                        Console.WriteLine();
                        Console.WriteLine(Users[Convert.ToInt32(u) - 1]);
                        Console.WriteLine();
                        while (true)
                        {
                            Console.WriteLine("1.Save Cafe");
                            Console.WriteLine("2.Favorite Cafes");
                            Console.WriteLine("3.Exit To Main Menu");
                            Console.WriteLine();
                            String z = Console.ReadLine();
                            Console.WriteLine();
                            switch (z)
                            {
                                case "1":
                                    Console.WriteLine("Choose cafe");
                                    Console.WriteLine();
                                    for (int i = 0; i < cafes.Count; i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        Console.WriteLine(cafes[i].Name);
                                    }
                                    Console.WriteLine();
                                    string m;
                                    while (true)
                                    {
                                        m = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(m) > cafes.Count || Convert.ToInt32(m) <= 0)
                                            {
                                                Console.WriteLine("Invalid number! Please Try Again!");
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Invalid number! Please Try Again!");
                                        }
                                    }
                                    Console.WriteLine();
                                    if (!Users[Convert.ToInt32(u) - 1].favoriteCafes.Contains(cafes[Convert.ToInt32(m) - 1]))
                                        Users[Convert.ToInt32(u) - 1].favoriteCafes.Add(cafes[Convert.ToInt32(m) - 1]);
                                    Console.WriteLine("This cafe have been added to your favorite cafes.");
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    foreach (var item in Users[Convert.ToInt32(u) - 1].favoriteCafes)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();
                                    break;
                                case "3":
                                    goto p;
                            }
                        }
                    p:
                        break;
                    case "5":
                        Console.WriteLine("Search cafe by name.");
                        Console.WriteLine();
                        string sv = Console.ReadLine();

                        List<Cafe> cafes1 = SearchByName(sv, cafes);
                        if (cafes1.Count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry! This cafe can't be found.");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine();
                        for (int i = 0; i < cafes1.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(cafes1[i]);
                        }
                        Console.WriteLine();

                        break;
                    default:
                        Console.WriteLine("Invalid number! Please try again!");
                        Console.WriteLine();
                        break;
                }

            }

        }
        public static List<Cafe> SearchByName(String Name, List<Cafe> Cafes)
        {
            List<Cafe> list = new List<Cafe>();
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name.ToLower().Contains(Name.ToLower()))
                {
                    list.Add(Cafes[i]);
                }
            }
            return list;


        }
    }
}
