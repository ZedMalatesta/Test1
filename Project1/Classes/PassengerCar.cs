using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerCar : RollingStockItem, IPassengerItem, IComparable<PassengerCar>, INameItem
    {
        private int _allSeatsNumber;
        private int _occupiedSeatsNumber;
        private QualityType _quality;
        private string _name;

        public PassengerCar(int weightNativet, string name, int allSeatsNumber, int occupiedSeatsNumber, QualityType quality)
            : base(weightNativet)
        {
            _allSeatsNumber = allSeatsNumber;
            _occupiedSeatsNumber = occupiedSeatsNumber;
            _quality = quality;
            _name = name;
        }

        public int AllSeatsNumber
        {
            get
            {
                return _allSeatsNumber;
            }
            set
            {
                _allSeatsNumber = value;
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                return _occupiedSeatsNumber;
            }
            set
            {
                _allSeatsNumber = value;
            }
        }

        public override double Weight()
        {
            return _weightNativet;
        }

        public string Name
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

        public QualityType Quality
        {
            get
            {
                return _quality;
            }
            set
            {
                _quality = value;
            }
        }

        public int CompareTo(PassengerCar other)
        {
            if (this.Quality > other.Quality)
                return 1;
            if (this.Quality < other.Quality)
                return -1;
            else
                return 0;
        }
    }
}
