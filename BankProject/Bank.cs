using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Bank
    {
        private string name;
        private List<Account> accounts;
        private List<Employee> employees;

        public Bank(string name)
        {
            this.name = name;
            this.accounts = new List<Account>();
            this.employees = new List<Employee>();
        }
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public Account GetAccount(string firstName, string lastName, DateTime creationDate)
        {
            foreach (Account item in accounts)
            {
                if (item.CreationDate == creationDate && item.Person.FirstName == firstName && item.Person.LastName == lastName)
                {
                    return item;
                }

            }
            return null;

        }
        public void DeleteAccount(string firstName, string lastName, DateTime creationDate)
        {

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].CreationDate == creationDate && accounts[i].Person.FirstName == firstName && accounts[i].Person.LastName == lastName)
                {
                    accounts.RemoveAt(i);
                }
            }
        }
        public decimal GetTotalBalacne()
        {
            decimal totalBalance = 0;
            foreach (Account item in accounts)
            {
                totalBalance += item.Balance;
            }
            return totalBalance;
        }

        public int NumberOfAccounts()
        {
            return accounts.Count();
        }
        public void HireEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void FireEmployee(string passport)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Passport == passport)
                {
                    employees.RemoveAt(i);
                    break;
                }
            }
        }
        public int NumberOfEmployees()
        {
            return employees.Count;
        }
        public void PrintEmployees() {

            Console.WriteLine(name);
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            } 
        }


    }
}
