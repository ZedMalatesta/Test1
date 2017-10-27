using Project1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    public class PassengerCarSequence : RollingStockItem, ICollection<PassengerCar>, ISeatsSearch
    {
        private ICollection<PassengerCar> _passengercars = new List<PassengerCar>(); 

        public PassengerCarSequence(int weightNativet) 
            : base(weightNativet)
        {
        }

        public int Count
        {
            get
            {
                return _passengercars.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return _passengercars.IsReadOnly;
            }
        }

        public int AllSeatsNumber
        {
            get
            {
                return _passengercars.Sum(x => x.AllSeatsNumber);
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                return _passengercars.Sum(x => x.OccupiedSeatsNumber);
            }
        }

        public void Add(PassengerCar item)
        {
            _passengercars.Add(item);
        }

        public void Clear()
        {
            _passengercars.Clear();
        }

        public bool Contains(PassengerCar item)
        {
            return _passengercars.Contains(item);
        }

        public void CopyTo(PassengerCar[] array, int arrayIndex)
        {
            _passengercars.CopyTo(array, arrayIndex);
        }


        public bool Remove(PassengerCar item)
        {
            return _passengercars.Remove(item);
        }

        public IEnumerator<PassengerCar> GetEnumerator()
        {
            return _passengercars.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); 
        }

        public override double Weight()
        {
            return _passengercars.Sum(x => x.Weight());
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int value)
        {
            try
            {
                if (value<0) { throw new System.ArgumentException("Parameter cannot be negative"); }
                return _passengercars.Where(x => x.OccupiedSeatsNumber== value).Select(x => x);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int minvalue, int maxvalue)
        {
            try
            {
                if (maxvalue<0 || minvalue<0) { throw new System.ArgumentException("Parameters cannot be negative"); }
                if (maxvalue == minvalue) { throw new System.ArgumentException("Parameters cannot be equals"); }
                if (maxvalue < minvalue)
                {
                    int valueH = maxvalue;
                    maxvalue = minvalue;
                    minvalue = valueH;
                }               
                return _passengercars.Where(x => (x.OccupiedSeatsNumber < maxvalue && x.OccupiedSeatsNumber > minvalue)).Select(x => x);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Sort()
        {
            List<PassengerCar> yan = _passengercars.ToList();
            yan.Sort();
            _passengercars = yan;          
        }
    }
}
