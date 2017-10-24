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
