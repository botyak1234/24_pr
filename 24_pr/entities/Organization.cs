using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    [Serializable]
    public class Organization : Client
    {
        public string Name { get; }
        public string AccountNumber { get; }
        protected double AccountBalance { get; }


        public Organization(string name, DateTime startDate, string accountNumber, double accountBalance) : base(name, startDate)
        {
            Name = name;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }




        public override string ToString()
        {
            return $"Organization: {Name}, Account Number: {AccountNumber}, Account Balance: {AccountBalance}";
        }
    }
}
