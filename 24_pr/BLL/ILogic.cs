using entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IClientLogic
    {
        void AddDepositor(string name, DateTime date, double amount, double deposit);
        void AddCreditor(string name, DateTime date, double creditAmount, double credit, double remainingCredit);
        void AddOrganization(string name, DateTime date, string accNum, double accBalance);
        void DeleteClient(string name);
        void DeleteClient(int index);
        IEnumerable GetAllClients();
        Client GetClient(int index);
    }
}
