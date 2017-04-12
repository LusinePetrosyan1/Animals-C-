using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public  class Employee : Person
    {
        protected decimal salary;
        protected DateTime hireDate;
        public Employee(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate) : base(firstName, lastName, dateOfBirth, passport)
        {
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public decimal GetAnnualSalary()
        {
            return 12 * salary;
        }
        public override string ToString()
        {
            return base.ToString() + " " + salary + " " + hireDate;
        }
    }
    public sealed class Engineer : Employee
    {
        public Engineer(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate) : base(firstName, lastName, dateOfBirth, passport, salary, hireDate)
        {

        }
        public override string GetEmploymentStatus()
        {
            return "Engineer";
        }
    }
    public sealed class Manager : Employee
    {
        string department;
        public Manager(string firstName, string lastName,DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate, string department) : base(firstName, lastName, dateOfBirth, passport, salary, hireDate)
        {
            this.department = department;
        }
        public override string GetEmploymentStatus()
        {
            return "Manager";
        }
        public override string ToString()
        {
            return base.ToString() + " " + department;
        }
    }
    public sealed class Secretary : Employee
    {

        public Secretary(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate) : base(firstName, lastName, dateOfBirth, passport, salary, hireDate)
        {

        }
        public override string GetEmploymentStatus()
        {
            return "Secretary";
        }

    }

}
