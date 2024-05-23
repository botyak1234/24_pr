using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    [Serializable]
    public abstract class Client : IComparable<Client>
    {
        public int Id { get; set; }
        public string LastName { get; }
        public DateTime StartDate { get; }

        public Client(string lastName, DateTime startDate)
        {
            LastName = lastName;
            StartDate = startDate;
        }

        public bool IsMatch(DateTime targetDate)
        {
            return StartDate >= targetDate;
        }


        public int CompareTo(Client other)
        {
            return StartDate.CompareTo(other.StartDate);
        }
    }
}
