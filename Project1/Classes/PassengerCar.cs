using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    class PassengerCar : IPassengerItem
    {
        public QualityType _quality { get; private set; }

        public int AllSeatsNumber
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
