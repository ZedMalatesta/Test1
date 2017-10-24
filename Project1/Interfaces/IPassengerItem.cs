using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Interfaces
{
    interface IPassengerItem
    {
        int SeatsNumber { get; }
        int OccupiedSeats { get; }
    }
}
