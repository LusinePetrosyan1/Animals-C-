using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            DateTime date2=new DateTime(date1.Year-50,date1.Month,date1.Day);
            Random r = new Random();
            Person person1 = new Person("Lily", "Smith", date1, "56487977");
            Account account1 = new Account(person1, r.Next(), DateTime.Parse("30.04.2017"), "AMD");
            Account account2 = new Account(person1, r.Next(), DateTime.Parse("05.04.2017"), "AMD");
            account1.DepositMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account1.DepositMoney(2000.0m, DateTime.Parse("04.04.2017"));
            account1.WithDrawMoney(500.0m, DateTime.Parse("05.04.2017"));
            account1.DepositMoney(500.0m, DateTime.Parse("05.04.2017"));
            account1.WithDrawMoney(1000.0m, DateTime.Parse("05.04.2017"));
            account1 = account1 + 5000;
            account1 = account1 - 2000;
            account2 = account2 + 400;
            account2 = account2 + 6000;
            account2 -= 4500;

            Console.WriteLine(account1>account2);
            account2.PrintAccountStatement();
            
            List<Account> accounts = new List<Account>();
            accounts.Add(account1);
            List<Employee> employees = new List<Employee>();
            employees.Add(new Engineer("Ann", "Black", DateTime.Parse("11.06.1987"), "56456587977", 50000000, DateTime.Parse("15.11.1999")));
            employees.Add(new Manager("Frank", "Lampard", DateTime.Parse("08.06.1977"), "12165699977979", 6444000, DateTime.Parse("15.02.1990"), "Engineering"));
            employees.Add(new Secretary("Justin", "Timberlake", DateTime.Parse("08.06.1980"), "564979799", 5640000, DateTime.Parse("15.02.1999")));
            Bank bank = new Bank("Ameria");
            bank.HireEmployee(employees[0]);
            bank.HireEmployee(employees[1]);
            bank.HireEmployee(employees[2]);
            bank.PrintEmployees();

            
        }
    }
}
