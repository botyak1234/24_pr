using entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseClients : IBaseClients
    {
        int index; //номер клиента, генерируется автоматически
        Dictionary<int, Client> clients; //список клиентов

        public BaseClients() //конструктор класса
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = new FileStream("data.dat", FileMode.OpenOrCreate);
            if (f.Length == 0) //файл пуст, создаю новую базу
            {
                clients = new Dictionary<int, Client>();
                index = 0;
            }
            else // иначе выполняю дисериализацию
            {
                clients = (Dictionary<int, Client>)formatter.Deserialize(f);
                ICollection key = clients.Keys; // ищу последний ключ
                foreach (int item in key)
                {
                    index = item;
                }
            }
            f.Close();

        }
        ~BaseClients()
        {
            SaveBaseClients();
        }
        public void AddClient(Client client) //добавление нового клиента в хеш-таблицу:
        { //ключ – index, значение – экземпляр класса Client
            index++;
            client.Id = index;
            clients.Add(index, client);
        }
        //добавление информации о покупке по номеру клиента
        //добавление информации о покупке по фамилии клиента
       
        //удаляем клиента по номеру
        public void DeleteClient(int index)
        {
            clients.Remove(index);
        }
        //удаляем клиента по фамилии
        public void DeleteClient(string name)
        {
            ICollection key = clients.Keys;
            foreach (int index in key)
            {
                Client item = clients[index];
                if (string.Compare(name, item.LastName) == 0)
                {
                    DeleteClient(index);
                    break;
                }
            }
        }

        public Client GetClient(int index)
        {
            return clients[index];
        }

        public IEnumerable GetAllClients()
        {
            return clients.Values;
        }

        void SaveBaseClients()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(f, clients);
            }
        }

    }
}
