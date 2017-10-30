using Project1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project1.Classes
{
    public class PassengerCarSequence : RollingStockItem, ICollection<PassengerCar>, ISeatsSearchingWithValidation, INotation
    {
        private ICollection<PassengerCar> _passengercars; 

        public PassengerCarSequence(ICollection<PassengerCar> passangerCar) 
        {
            _passengercars = passangerCar;
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
                return _passengercars
                    .Sum(x => x.AllSeatsNumber);
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                return _passengercars
                    .Sum(x => x.OccupiedSeatsNumber);
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
            return _passengercars
                .Sum(x => x.Weight());
        }

        public bool SeatsValidation(int value)
        {
            try
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Parameter cannot be negative");
                }
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public bool SeatsValidation(int value1, int value2)
        {
            try
            {
                if (value1 == value2) {                   
                    throw new System.ArgumentException("Parameters cannot be equals");
                }
                if (value1<0 || value2<0)
                {
                    throw new System.ArgumentException("Parameters cannot be negative");
                }
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int value)
        {
            if (SeatsValidation(value))
            {
                return _passengercars
                    .Where(x => x.OccupiedSeatsNumber == value)
                    .Select(x => x);
            }
            else return null;
        }

        public IEnumerable<IPassengerItem> SearchForPassengerNumber(int minvalue, int maxvalue)
        {
            if (SeatsValidation(minvalue, maxvalue))
            {
                return _passengercars
                    .Where(x => (x.OccupiedSeatsNumber < maxvalue && x.OccupiedSeatsNumber > minvalue))
                    .Select(x => x);
            }
            else return null;
        }

        public IEnumerable<IPassengerItem> Sort()
        {
            return _passengercars
                .OrderBy(x => x.Quality);
        }

        public IEnumerable<string> Notation()
        {
            return _passengercars.Select(x => x.ToString());
        }
    }
}
