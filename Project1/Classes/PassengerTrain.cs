using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerTrain : Train, ISeatsSearch, IFreightItem, INameItem
    {
        private string _name;
        private BaggageCarSequence _baggageCompartment;
        private PassengerCarSequence _passengerCompartment;

        public PassengerTrain(int weightNative, string name, Locomotive head, BaggageCarSequence baggageCompartment, PassengerCarSequence passengerCompartment) 
            : base(weightNative, head)
        {           
            _baggageCompartment = baggageCompartment;
            _passengerCompartment = passengerCompartment;
            _name = name;
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

        string INameItem.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override double Weight()
        {
            return _head.Weight()+_baggageCompartment.Weight()+_passengerCompartment.Weight();
        }

        public override Locomotive Head()
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

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int value)
        {
            return _passengerCompartment.SearchForPassengerNumber(value);
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int minvalue, int maxvalue)
        {
            return _passengerCompartment.SearchForPassengerNumber(minvalue, maxvalue);
        }
    }
}
