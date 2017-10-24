using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    class PassengerTrain : Train, IPassengerItem
    {
        public PassengerTrain(int weightNative) 
            : base(weightNative)
        {
        }

        public int SeatsNumber 
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int OccupiedSeats
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    }
}
