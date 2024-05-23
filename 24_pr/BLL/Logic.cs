using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using entities;

namespace BLL
{
    public class ClientLogic : IClientLogic
    {
        private IBaseClients baseClients;

        public ClientLogic(IBaseClients baseClients)
        {
            this.baseClients = baseClients;
        }

        public void AddDepositor(string name, DateTime date, double amount, double deposit)
        {
            baseClients.AddClient(new Depositor(name, date, amount, deposit));
        }

        public void AddCreditor(string name, DateTime date, double creditAmount, double credit, double remainingCredit)
        {
            baseClients.AddClient(new Creditor(name, date, creditAmount, credit, remainingCredit));
        }

        public void AddOrganization(string name, DateTime date, string accNum, double accBalance)
        {
            baseClients.AddClient(new Organization(name, date, accNum, accBalance));
        }

        //удаляем клиента по номеру
        public void DeleteClient(int index)
        {
            baseClients.DeleteClient(index);
        }
        //удаляем клиента по фамилии
        public void DeleteClient(string name)
        {
            baseClients.DeleteClient(name);
        }

        public Client GetClient(int index)
        {
            return baseClients.GetClient(index);
        }

        public IEnumerable GetAllClients()
        {
            return baseClients.GetAllClients();
        }
    }
}
