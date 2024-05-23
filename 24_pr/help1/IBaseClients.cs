using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace DAL
{
    public interface IBaseClients
    {
        void AddClient(Client client);
        void DeleteClient(string name);
        void DeleteClient(int index);
        IEnumerable GetAllClients();
        Client GetClient(int index);
    }
}
