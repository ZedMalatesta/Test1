using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerTrain : Train, ISeatsSearching, IFreightItem, INameItem, INotation
    {
        private BaggageCarSequence _baggageCompartment;
        private PassengerCarSequence _passengerCompartment;

        public PassengerTrain(string name, Locomotive head, BaggageCarSequence baggageCompartment, PassengerCarSequence passengerCompartment) 
            : base(head)
        {
            _baggageCompartment = baggageCompartment;
            _passengerCompartment = passengerCompartment;
            Name = name;
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

        public string Name
        {
            get;
            private set;
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

        public IEnumerable<IPassengerItem> Sort()
        {
            return _passengerCompartment.Sort();
        }

        public override double TractionForce()
        {
            return (735.5*_head.PowerkW/(100/5));        
        }

        public override void ChangeHead(Locomotive value)         
        {
            _head=value;
        }

        public override bool TractionForceTest()
        {
             if (((TractionForce()-(1.88 + 9.5)*130)/(1.88 + 9.5))>(Weight()+100)) return true;
             else return false;
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int value)
        {
            return _passengerCompartment.SearchForPassengerNumber(value);
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int minvalue, int maxvalue)
        {
            return _passengerCompartment.SearchForPassengerNumber(minvalue, maxvalue);
        }

        public IEnumerable<string> Notation()
        {
            return _passengerCompartment.Notation().Concat(_baggageCompartment.Notation()).Concat(new string[] { _head.ToString() });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
