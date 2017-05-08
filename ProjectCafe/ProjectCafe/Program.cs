using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;
using System.Reflection;

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
                    Users.Add(new User(linearr[0], linearr[1], Convert.ToInt32(linearr[2]), linearr[3],linearr[4],linearr[5],linearr[6]));
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
                Console.WriteLine("1.User registration");
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
                            Console.WriteLine("Enter Name");
                            string userName = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter Surname");
                            string userSurname = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter Age");
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
                                    MessageBox.Show("Invalid age! Please try again!");
                                    
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Enter User's Mail");
                            MailAddress Mail;
                            string userMail;
                            while (true)
                            {
                                userMail = Console.ReadLine();
                                try
                                {
                                    Mail = new MailAddress(userMail);
                                    break;
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Invalid mail! Please try again!");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Enter Username");
                            String UserName;
                            bool a = true;
                            while(true){
                                a=true;
                                UserName=Console.ReadLine();
                                foreach (var user in Users){
                                    if(user.Username==UserName){
                                        MessageBox.Show("This username is already taken! Choose another one!");
                                        a = false;
                                        break;
                                    }
                                     else if(UserName==""){
                                        MessageBox.Show("Invalid username! Try again!");
                                        a = false;
                                        break;
                                    }
                                }
                                if (a)
                                    break;

                            }
                            Console.WriteLine();
                            Console.WriteLine("Enter Password");
                            String Password;
                            while(true){
                                Password=Console.ReadLine();
                                    if(Password==""){
                                        MessageBox.Show("Invalid password! Try again!");
                                    }
                                    else
                                        break;
                            }
                            Console.WriteLine();
                            MessageBox.Show("Account has been successfully created!");
                            Console.WriteLine();

                            using (writer = new StreamWriter("Users.txt", true))
                            {
                                writer.Write(userName + " " + userSurname + " " + age + " " + userMail + " " + "user"+" "+UserName+" "+Password+"\r\n");
                                writer.Flush();
                                writer.Close();
                            }
                            try
                            {
                                Users.Add(new User(userName, userSurname, age, userMail, "user",UserName,Password));
                                break;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error!Pleases try again!");
                            }

                        }
                        break;
                    case "2":
                        Console.WriteLine("Only administrators can use this function!");
                        Console.WriteLine("If you are an administrator please login!");
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1.Login");
                            Console.WriteLine("2.Exit to main menu");
                            Console.WriteLine();
                            string ch = Console.ReadLine();
                            switch (ch)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("Enter username");
                                    Console.WriteLine();
                                    string us = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter password");
                                    Console.WriteLine();
                                    string ps = Console.ReadLine();
                                    foreach (var item in Users)
                                    {
                                        if (item.Username == us && item.Password == ps)
                                        {
                                            if (item.Type == "admin")
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Welcome " + item.Name);
                                                Console.WriteLine();
                                                goto sc;
                                            }
                                        }                                           
                                    }
                                    Console.WriteLine();
                                    MessageBox.Show("Incorrect username or password");
                                    break;
                                case "2":
                                    goto z;
                                default:
                                    MessageBox.Show("Invalid number! Please Try Again!");
                                    break;
                            }

                        }
                        sc:
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
                               
                                MessageBox.Show("Invalid latitude! Please try again!");
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
                                MessageBox.Show("Invalid longitude! Please try again!"); ;
                               
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
                                MessageBox.Show("Invalid age! Please try again!");
                            }
                        }

                        Console.WriteLine();
                       MessageBox.Show("Cafe has successfully been created!");
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
                                    MessageBox.Show("Invalid number! Please try again!");
                                    Console.WriteLine();
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Invalid number! Please try again!");
                                Console.WriteLine();
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
                                    Console.WriteLine("How far?");
                                    double x;

                                    while (true)
                                    {
                                        try
                                        {
                                            x = Convert.ToDouble(Console.ReadLine());
                                            break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine();
                                            MessageBox.Show("Invalid number! Please try again!");

                                        }
                                    }


                                    cafes[Convert.ToInt32(c) - 1].Nearby(cafes,Convert.ToDouble(x));
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
                                    Console.WriteLine("Please sign in first");
                                    int userindex;
                                    while (true)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("1.Login");
                                        Console.WriteLine("2.Exit to main menu");
                                        Console.WriteLine();
                                        string ch = Console.ReadLine();
                                        switch (ch)
                                        {
                                            case "1":
                                                Console.WriteLine();
                                                Console.WriteLine("Enter username");
                                                Console.WriteLine();
                                                string us = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Enter password");
                                                Console.WriteLine();
                                                string ps = Console.ReadLine();
                                                userindex=0;
                                                for (int i = 0; i < Users.Count;i++ )
                                                {
                                                    User item = Users[i];
                                                    if (item.Username == us && item.Password == ps)
                                                    {
                                                        userindex = i;
                                                        goto ss;
                                                    }
                                                }
                                                Console.WriteLine();
                                                MessageBox.Show("Incorrect username or password");
                                                break;
                                            case "2":
                                                goto z;
                                            default:
                                                MessageBox.Show("Invalid number! Please Try Again!");
                                                break;
                                        }

                                    }
                            ss:
                                    Console.WriteLine();
                                    Console.WriteLine("Write Your Oppinion");
                                    String op = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Write Your Rate (0-5)");
                                    String ra;
                                    while (true)
                                    {
                                        ra = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(ra) > 5 || Convert.ToInt32(ra) < 0)
                                            {
                                             
                                               MessageBox.Show("Invalid number! Please try again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                goto gt;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Invalid number! Please try again!");
                                            Console.WriteLine();
                                        }
                                    }
                                gt:
                                    bool over=false;
                                    for (int i = 0; i < cafes[Convert.ToInt32(c) - 1].Reviews.Count; i++)
                                    {
                                        Review rev = cafes[Convert.ToInt32(c) - 1].Reviews[i];
                                        if (rev.User.Username == Users[userindex].Username)
                                        {
                                            rev.Date = DateTime.Now;
                                            rev.Opinion = op;
                                            rev.Rate = int.Parse(ra);
                                            over = true;
                                            MessageBox.Show("Thank you for your rate!");
                                            break;
                                        }
                                    }
                                    if (!over)
                                    {
                                        cafes[Convert.ToInt32(c) - 1].AddNewReview(new Review(Users[userindex], DateTime.Now, op, Convert.ToInt32(ra)));
                                        MessageBox.Show("Thank you for your rate!");
                                        Console.WriteLine();
                                    }
                                    break;
                                case "5":
                                    Console.WriteLine("Please sign in first");
                                    while (true)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("1.Login");
                                        Console.WriteLine("2.Exit to main menu");
                                        Console.WriteLine();
                                        string ch = Console.ReadLine();
                                        switch (ch)
                                        {
                                            case "1":
                                                Console.WriteLine();
                                                Console.WriteLine("Enter username");
                                                Console.WriteLine();
                                                string us = Console.ReadLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Enter password");
                                                Console.WriteLine();
                                                string ps = Console.ReadLine();
                                                userindex = 0;
                                                for (int i = 0; i < Users.Count; i++)
                                                {
                                                    User item = Users[i];
                                                    if (item.Username == us && item.Password == ps)
                                                    {
                                                        userindex = i;
                                                        goto sq;
                                                    }
                                                }
                                                Console.WriteLine();
                                                MessageBox.Show("Incorrect username or password");
                                                break;
                                            case "2":
                                                goto z;
                                            default:
                                                MessageBox.Show("Invalid number! Please Try Again!");
                                                break;
                                        }
                                    }
                            sq:
                                    Console.WriteLine();
                                    cafes[int.Parse(c) - 1].Visit(Users[userindex]);
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
                                           Console.WriteLine();
                                    Console.WriteLine("Write Your Oppinion");
                                    op = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Write Your Rate (0-5)");
                                    while (true)
                                    {
                                        ra = Console.ReadLine();
                                        try
                                        {
                                            if (Convert.ToInt32(ra) > 5 || Convert.ToInt32(ra) < 0)
                                            {
                                             
                                               MessageBox.Show("Invalid number! Please try again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                goto gq;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Invalid number! Please try again!");
                                            Console.WriteLine();
                                        }
                                    }
                                gq:
                                    over=false;
                                    for (int i = 0; i < cafes[Convert.ToInt32(c) - 1].Reviews.Count; i++)
                                    {
                                        Review rev = cafes[Convert.ToInt32(c) - 1].Reviews[i];
                                        if (rev.User.Username == Users[userindex].Username)
                                        {
                                            rev.Date = DateTime.Now;
                                            rev.Opinion = op;
                                            rev.Rate = int.Parse(ra);
                                            over = true;
                                            MessageBox.Show("Thank you for your rate!");
                                            break;
                                        }
                                    }
                                    if (!over)
                                    {
                                        cafes[Convert.ToInt32(c) - 1].AddNewReview(new Review(Users[userindex], DateTime.Now, op, Convert.ToInt32(ra)));
                                        MessageBox.Show("Thank you for your rate!");
                                        Console.WriteLine();
                                    }
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
                                                MessageBox.Show("Invalid number! Please Try Again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine();
                                            MessageBox.Show("Invalid number! Please Try Again!");
                                            Console.WriteLine();
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Distance of "+ cafes[int.Parse(c)-1].Name + " from "+ cafes[int.Parse(cnum)-1].Name +" is`");
                                    Console.WriteLine(cafes[int.Parse(c) - 1].DistanceFrom(cafes[int.Parse(cnum) - 1]));
                                    Console.WriteLine();
                                    break;

                                case "8":
                                    goto x;
                                default:
                                    MessageBox.Show("Invalid number!Please try again!");
                                    break;
                            }
                        }
                    x:
                        break;
                    case "4":
                        Console.WriteLine("Only administrators can use this function!");
                        Console.WriteLine("If you are an administrator please login!");
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1.Login");
                            Console.WriteLine("2.Exit to main menu");
                            Console.WriteLine();
                            string ch = Console.ReadLine();
                            switch (ch)
                            {
                                case "1":
                                    Console.WriteLine();
                                    Console.WriteLine("Enter username");
                                    Console.WriteLine();
                                    string us = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Enter password");
                                    Console.WriteLine();
                                    string ps = Console.ReadLine();
                                    foreach (var item in Users)
                                    {
                                        if (item.Username == us && item.Password == ps)
                                        {
                                            if (item.Type == "admin")
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Welcome " + item.Name);
                                                Console.WriteLine();
                                                goto sa;
                                            }
                                        }
                                    }
                                    Console.WriteLine();
                                    MessageBox.Show("Incorrect username or password");
                                    break;
                                case "2":
                                    goto z;
                                default:
                                    MessageBox.Show("Invalid number! Please Try Again!");
                                    break;
                            }
                        }
                        sa:
                        for (int i = 0; i < Users.Count; i++)
                        {
                            Console.Write(i + 1 + ".");
                            Console.WriteLine(Users[i]);
                        }
                        Console.WriteLine(Users.Count + 1 + "." + "Exit To Main Menu");
                        string u;
                        Console.WriteLine();
                        while (true)
                        {
                           
                            u = Console.ReadLine();
                            try
                            {
                                if (Convert.ToInt32(u) > Users.Count + 1 || Convert.ToInt32(u) <= 0)
                                {
                                    Console.WriteLine();
                                   MessageBox.Show("Invalid number! Please Try Again!");
                                    
                                }
                                else
                                    break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine();
                              MessageBox.Show("Invalid number! Please Try Again");
                              
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
                                                MessageBox.Show("Invalid number! Please Try Again!");
                                                Console.WriteLine();
                                            }
                                            else
                                                break;
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Invalid number! Please Try Again!");
                                            Console.WriteLine();
                                        }
                                    }
                                    Console.WriteLine();
                                    MessageBox.Show("This cafe has been added to your favorite cafes!");
                                    if (!Users[Convert.ToInt32(u) - 1].favoriteCafes.Contains(cafes[Convert.ToInt32(m) - 1]))
                                        Users[Convert.ToInt32(u) - 1].favoriteCafes.Add(cafes[Convert.ToInt32(m) - 1]);
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
                                default:
                                    MessageBox.Show("Invalid Number! Please try again!");
                                    break;
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
                            MessageBox.Show("Sorry! This cafe can't be found.");
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
                        MessageBox.Show("Invalid number! Please try again!");
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
