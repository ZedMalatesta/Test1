using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Classes;

namespace Project1.Interfaces
{
    public interface ISeatsSearching : IPassengerItem
    {
        IEnumerable<IPassengerItem> SearchForPassengerNumber(int value);
        IEnumerable<IPassengerItem> SearchForPassengerNumber(int minvalue, int maxvalue);
    }
}
