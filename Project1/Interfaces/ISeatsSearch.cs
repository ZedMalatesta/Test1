using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Classes;

namespace Project1.Interfaces
{
    public interface ISeatsSearch : IPassengerItem
    {
        IEnumerable<PassengerCar> SearchForPassengerNumber(int value);
        IEnumerable<PassengerCar> SearchForPassengerNumber(int minvalue, int maxvalue);
    }
}
