using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerTrain : Train, IPassengerItem, IFreightItem
    {
        private Locomotive _head { get; set; }
        private BaggageCarSequence _baggageCompartment { get; set; }
        private PassengerCarSequence _passengerCompartment { get; set; }

        public PassengerTrain(int weightNative, string name, Locomotive head, BaggageCarSequence baggageCompartment, PassengerCarSequence passengerCompartment) 
            : base(weightNative, name)
        {
            _head = head;
            _baggageCompartment = baggageCompartment;
            _passengerCompartment = passengerCompartment;
        }

        public int AllSeatsNumber 
        {
            get
            {
                return _passengerCompartment.AllSeatsNumber;
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                return _passengerCompartment.OccupiedSeatsNumber;
            }
        }

        public double FreightCapacity
        {
            get
            {
                return _baggageCompartment.FreightCapacity;
            }
        }

        public double FreightWeight
        {
            get
            {
                return _baggageCompartment.FreightWeight;
            }
        }

        public override double Weight()
        {
            return _head.Weight()+_baggageCompartment.Weight()+_passengerCompartment.Weight();
        }

        public override string Name()
        {
            return _name;
        }

        public Locomotive Head()
        {
            return _head;
        }

        public BaggageCarSequence BC()
        {        
            return _baggageCompartment;
        }

        public PassengerCarSequence PC()
        {
            return _passengerCompartment;
        }

        public void Sort()
        {
            _passengerCompartment.Sort();
        }

        public IEnumerable<PassengerCar> SearchForPassengerNumber(int value)
        {
            return _passengerCompartment.SearchForPassengerNumber(value);
        }

        public IEnumerable<PassengerCar> SearchForPassengerNumber(int minvalue, int maxvalue)
        {
            return _passengerCompartment.SearchForPassengerNumber(minvalue, maxvalue);
        }
    }
}
