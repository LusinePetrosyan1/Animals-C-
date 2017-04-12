using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Account
    {
        private int accountNo;
        private string currency;
        private decimal balance;
        private List<Transaction> transactions;
        public Person Person { get; set; }
        public DateTime CreationDate { get; set; }

        public Account(Person person, int accountNo, DateTime creationDate, string currency, decimal balance = 0)
        {
            Person = person;
            this.accountNo = accountNo;
            CreationDate = creationDate;
            this.currency = currency;
            Balance = balance;
            transactions = new List<Transaction>();

        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance can't be negative!");
                }
                balance = value;
            }

        }

        public List<Transaction> Transactions
        {
            get
            {
                return transactions;
            }

            set
            {
                transactions = value;
            }
        }

        public void DepositMoney(decimal money, DateTime date)
        {
            Balance += money;
            Transactions.Add(new Transaction(money, date));
        }
        public void WithDrawMoney(decimal money, DateTime date)
        {
            Balance -= money;
            Transactions.Add(new Transaction(-money, date));
        }
        public void PrintAccountStatement()
        {
            Console.WriteLine(Person);
            for (int i = 0; i < Transactions.Count; i++)
            {
                Console.Write(Transactions[i].ToString());
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("Current Balance {0},{1}", balance, currency);
        }
        public override string ToString()
        {
            return Person + " " + accountNo + " " + CreationDate + " " + currency + " " + balance;
        }
        public static Account operator +(Account account, decimal money)
        {
            account.DepositMoney(money, DateTime.Now);
            return account;
        }
        public static Account operator -(Account account, decimal money)
        {
            account.WithDrawMoney(money, DateTime.Now);
            return account;
        }
        public static bool operator >(Account account1, Account account2)
        {
            return account1.balance > account2.balance;

        }
        public static bool operator <(Account account1, Account account2)
        {
            return account1.balance < account2.balance;

        }


    }

}
public class Transaction
{
    private decimal money;
    private DateTime date;
    public Transaction(decimal money, DateTime date)
    {
        this.money = money;
        this.date = date;
    }
    public override string ToString()
    {
        return date + " " + money;
    }


}